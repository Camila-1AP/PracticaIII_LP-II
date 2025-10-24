using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3LP2
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombrePro.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(maskTelPro.Text))
            {
                MessageBox.Show("El campo de teléfono esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!maskTelPro.MaskFull)
            {
                MessageBox.Show("Por favor ingresa un número de teléfono completo.");
                maskTelPro.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEmailPro.Text))
            {
                MessageBox.Show("El campo de correo electrónico esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Regex.IsMatch(txtEmailPro.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Correo electrónico inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailPro.Focus();
                return;
            }
            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; TrustServerCertificate=True; Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryAddProveedores = @"INSERT INTO Proveedores (NombreProveedor, Telefono, CorreoElectronico)
                                          VALUES (@nombre, @telefono, @correo)";
               


                using (SqlCommand cmd = new SqlCommand(queryAddProveedores, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombrePro.Text);
                    cmd.Parameters.AddWithValue("@telefono", maskTelPro.Text);
                    cmd.Parameters.AddWithValue("@correo", txtEmailPro.Text);


                    


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado al Proveedor en la base de datos.");
                        txtEmailPro.Clear();
                        maskTelPro.Clear();
                        txtNombrePro.Clear();
                    }
                }






            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryProveedores = "SELECT * FROM Proveedores;";

                using (SqlCommand cmd = new SqlCommand(queryProveedores, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvProveedores.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDPro.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }
            if (MessageBox.Show("Recuerde al aceptar eliminar este proveedor, los detalles de compra, relacionados al proveedor se eliminarán. Quizás quiera revisarlos antes.", "Advertencia de Eliminación de categoría", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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


                        // 1. Eliminar DetallesCompra vinculados a Proveedor, eliminamos primera esta valor porque esta como foreign Key en Compras
                        // Por eso luego eliminamos Compra ya que el su vinculo existe y no habría problemas
                        string deleteDetallesCompra = @"
                                        DELETE FROM DetallesCompra
                                        WHERE CompraID IN (
                                            SELECT CompraID FROM Compras WHERE ProveedorID = @proveedorID
                                        )";
                        using (SqlCommand cmd2 = new SqlCommand(deleteDetallesCompra, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@proveedorID", txtIDPro.Text);
                            cmd2.ExecuteNonQuery();
                        }
                        
                        string deleteCompras = @"
                                        DELETE FROM Compras
                                        WHERE ProveedorID = @proveedorID
                                        ";
                        using (SqlCommand cmd1 = new SqlCommand(deleteCompras, connection, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@proveedorID", txtIDPro.Text);
                            cmd1.ExecuteNonQuery();
                        }
 

                      
                        

                        string deleteProveedor = @"DELETE FROM Proveedores WHERE ProveedorID = @proveedorID";
                        using (SqlCommand cmd4 = new SqlCommand(deleteProveedor, connection, transaction))
                        {
                            cmd4.Parameters.AddWithValue("@proveedorID", txtIDPro.Text);
                            cmd4.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Proveedor y registros vinculados eliminados correctamente.");
                        txtIDproUp.Clear();
                        txtEmailProUp.Clear();
                        txtNombreProUp.Clear();
                        maskTelProUp.Clear();
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
           

            if (string.IsNullOrEmpty(txtIDproUp.Text))
            {
                MessageBox.Show("El campo de ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtNombreProUp.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(maskTelProUp.Text))
            {
                MessageBox.Show("El campo de teléfono esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!maskTelProUp.MaskFull)
            {
                MessageBox.Show("Por favor ingresa un número de teléfono completo.");
                maskTelProUp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtEmailProUp.Text))
            {
                MessageBox.Show("El campo de correo electrónico esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Regex.IsMatch(txtEmailProUp.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Correo electrónico inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailProUp.Focus();
                return;
            }

            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryUpdateProveedores = @"UPDATE Proveedores
                                                    SET 
                                                        NombreProveedor = @nombre,
                                                        Telefono = @telefono,
                                                        CorreoElectronico = @correo

                                                    WHERE ProveedorID = @proveedorID";

                using (SqlCommand cmd = new SqlCommand(queryUpdateProveedores, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreProUp.Text);
                    cmd.Parameters.AddWithValue("@telefono", maskTelProUp.Text);
                    cmd.Parameters.AddWithValue("@correo", txtEmailProUp.Text);
                    cmd.Parameters.AddWithValue("@proveedorID", txtIDproUp.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha actualizado al proveedor en la base de datos.");
                        txtEmailPro.Clear();
                        maskTelPro.Clear();
                        txtNombrePro.Clear();
                        txtIDproUp.Clear();
                    }
                }

                connection.Close();
            }
        }

        private void txtNombrePro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreProUp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmailPro_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEmailProUp_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNombreProUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDPro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIDproUp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmailPro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmailProUp_KeyPress(object sender, KeyPressEventArgs e)
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
