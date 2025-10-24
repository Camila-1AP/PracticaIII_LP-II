using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Unidad3LP2
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtIDcateUp.Text))
            {
                MessageBox.Show("El campo de ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtNombreCateUp.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }




            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryUpdateCategorias = @"UPDATE Categorias
                                                    SET 
                                                        NombreCategoria = @nombre



                                                    WHERE CategoriaID = @categoriaID";

                using (SqlCommand cmd = new SqlCommand(queryUpdateCategorias, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCateUp.Text);
                    cmd.Parameters.AddWithValue("@categoriaID", txtIDcateUp.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha actualizado la categoría en la base de datos.");
                        txtIDcateUp.Clear();
                        txtNombreCateUp.Clear();
                    }
                }

                connection.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDcate.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }
            if (MessageBox.Show("Recuerde al aceptar eliminar esta categoría, los productos, detalles factura y detalles compra, relacionados con los produtos en dicha categoría se eliminarán. Quizás quiera revisarlos antes.", "Advertencia de Eliminación de categoría", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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
                        //Eliminar DetallesFactura vinculados a productos de la categoría
                        string deleteDetallesFactura = @"
                                        DELETE FROM DetallesFactura
                                        WHERE ProductoID IN (
                                            SELECT ProductoID FROM Productos WHERE CategoriaID = @categoriaID
                                        )";
                        using (SqlCommand cmd1 = new SqlCommand(deleteDetallesFactura, connection, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@categoriaID", txtIDcate.Text);
                            cmd1.ExecuteNonQuery();
                        }

                        //Eliminar DetallesCompra vinculados
                        string deleteDetallesCompra = @"
                                        DELETE FROM DetallesCompra
                                        WHERE ProductoID IN (
                                            SELECT ProductoID FROM Productos WHERE CategoriaID = @categoriaID
                                        )";
                        using (SqlCommand cmd2 = new SqlCommand(deleteDetallesCompra, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@categoriaID", txtIDcate.Text);
                            cmd2.ExecuteNonQuery();
                        }

                        //Eliminar productos
                        string deleteProductos = @"DELETE FROM Productos WHERE CategoriaID = @categoriaID";
                        using (SqlCommand cmd3 = new SqlCommand(deleteProductos, connection, transaction))
                        {
                            cmd3.Parameters.AddWithValue("@categoriaID", txtIDcate.Text);
                            cmd3.ExecuteNonQuery();
                        }

                        //Eliminar categoría
                        string deleteCategoria = @"DELETE FROM Categorias WHERE CategoriaID = @categoriaID";
                        using (SqlCommand cmd4 = new SqlCommand(deleteCategoria, connection, transaction))
                        {
                            cmd4.Parameters.AddWithValue("@categoriaID", txtIDcate.Text);
                            cmd4.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Categoría y registros vinculados eliminados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }

                    

                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombreCate.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; TrustServerCertificate=True; Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryAddCategorias = @"INSERT INTO Categorias (NombreCategoria)
                                          VALUES (@nombre)";
                


                using (SqlCommand cmd = new SqlCommand(queryAddCategorias, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCate.Text);



                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado la categoría en la base de datos.");
                        txtNombreCate.Clear();


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

                string queryCategorias = "SELECT * FROM Categorias;";

                using (SqlCommand cmd = new SqlCommand(queryCategorias, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvCategorias.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void txtNombreCate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreCateUp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Categorias_Load(object sender, EventArgs e)
        {

        }

        private void txtIDcate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIDcateUp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
