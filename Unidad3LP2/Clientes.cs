using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3LP2
{
    public partial class Clientes : Form
    {


        public Clientes()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCli.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtEmailCli.Text))
            {
                MessageBox.Show("El campo de correo electrónico esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Regex.IsMatch(txtEmailCli.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Correo electrónico inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailCli.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskTelCli.Text))
            {
                MessageBox.Show("El campo de teléfono esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!maskTelCli.MaskFull)
            {
                MessageBox.Show("Por favor ingresa un número de teléfono completo.");
                maskTelCli.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDirCli.Text))
            {
                MessageBox.Show("El campo de dirección esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; TrustServerCertificate=True; Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryAddClientes = @"INSERT INTO Clientes (NombreCompleto, CorreoElectronico, Telefono, Direccion)
                                          VALUES (@nombre, @correo, @telefono, @direccion)";
                //Consulta con parámetros
                /* string queryInsertarPersonas = @"INSERT INTO personas (nombre, apellido, fecha_nacimiento, genero, nacionalidad)
                                          VALUES (@nombre, @apellido, @fechaNacimiento, @genero, @nacionalidad)";*/


                using (SqlCommand cmd = new SqlCommand(queryAddClientes, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCli.Text);
                    cmd.Parameters.AddWithValue("@correo", txtEmailCli.Text);
                    cmd.Parameters.AddWithValue("@telefono", maskTelCli.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDirCli.Text);

                    /* cmd.Parameters.AddWithValue("@nombre", nombre);
                     cmd.Parameters.AddWithValue("@apellido", apellido);


                     cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);

                     cmd.Parameters.AddWithValue("@genero", sexo);
                     cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);

                     int rowsAffected = cmd.ExecuteNonQuery();
                     if (rowsAffected > 0)
                     {
                         MessageBox.Show("Se ha insertado a la persona en la base de datos.");
                     }
                    */


                    int rowsAffected = cmd.ExecuteNonQuery(); // ExecuteNonQuery no devuelve el número de filas afectadas en Update, Insert y Delete
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado al cliente en la base de datos.");
                        txtNombreCli.Clear();
                        txtEmailCli.Clear();
                        maskTelCli.Clear();
                        txtDirCli.Clear();

                    }
                }






            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDcli.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (MessageBox.Show("Recuerde al aceptar eliminar este cliente, también se eliminarán las facturas de dicho cliente. Quizás quiera revisarlas antes.", "Advertencia de Eliminación de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
                string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        //Eliminar DetallesFactura
                        string deleteDetalles = @"
                                                DELETE FROM DetallesFactura 
                                                WHERE FacturaID IN (
                                                    SELECT FacturaID FROM Facturas WHERE ClienteID = @ClienteID
                                                )";
                        using (SqlCommand cmdDetalles = new SqlCommand(deleteDetalles, connection, transaction))
                        {
                            cmdDetalles.Parameters.AddWithValue("@ClienteID", txtIDcli.Text);
                            cmdDetalles.ExecuteNonQuery();
                        }

                        //Eliminar Facturas
                        string deleteFacturas = @"DELETE FROM Facturas WHERE ClienteID = @ClienteID";
                        using (SqlCommand cmdFacturas = new SqlCommand(deleteFacturas, connection, transaction))
                        {
                            cmdFacturas.Parameters.AddWithValue("@ClienteID", txtIDcli.Text);
                            cmdFacturas.ExecuteNonQuery();
                        }

                        //Eliminar Clientes
                        string deleteCliente = @"DELETE FROM Clientes WHERE ClienteID = @ClienteID";
                        using (SqlCommand cmdCliente = new SqlCommand(deleteCliente, connection, transaction))
                        {
                            cmdCliente.Parameters.AddWithValue("@ClienteID", txtIDcli.Text);
                            int rowsAffected = cmdCliente.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente eliminado correctamente.");

                                txtIDcli.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el cliente.");
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
        }





        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDCliUp.Text))
            {
                MessageBox.Show("El campo de ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtNombreCliUp.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtEmailCliUp.Text))
            {
                MessageBox.Show("El campo de correo electrónico esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Regex.IsMatch(txtEmailCliUp.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Correo electrónico inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailCliUp.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskTelCliUp.Text))
            {
                MessageBox.Show("El campo de teléfono esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!maskTelCliUp.MaskFull)
            {
                MessageBox.Show("Por favor ingresa un número de teléfono completo.");
                maskTelCliUp.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDirCliUp.Text))
            {
                MessageBox.Show("El campo de dirección esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryUpdateClientes = @"UPDATE Clientes
                                                    SET 
                                                        NombreCompleto = @nombre,
                                                        CorreoElectronico = @correo,
                                                        Telefono = @telefono,
                                                        Direccion = @direccion


                                                    WHERE ClienteID = @clienteID";

                using (SqlCommand cmd = new SqlCommand(queryUpdateClientes, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCliUp.Text);
                    cmd.Parameters.AddWithValue("@correo", txtEmailCliUp.Text);
                    cmd.Parameters.AddWithValue("@telefono", maskTelCliUp.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDirCliUp.Text);
                    cmd.Parameters.AddWithValue("@clienteID", txtIDCliUp.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha actualizado al proveedor en la base de datos.");
                        txtNombreCliUp.Clear();
                        txtEmailCliUp.Clear();
                        maskTelCliUp.Clear();
                        txtDirCliUp.Clear();
                        txtIDCliUp.Clear();
                    }

                }

                connection.Close();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryClientes = "SELECT * FROM Clientes;";

                using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvClientes.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true; 
            }

        }
        private bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private void txtEmailCli_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void txtEmailCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {

                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtNombreCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCliUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true; 
            }
        }

        private void txtNombreCliUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtIDCliUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEmailCliUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailCliUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {

                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }
    }
}
