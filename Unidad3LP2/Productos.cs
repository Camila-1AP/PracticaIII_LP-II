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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void CargarcmbCategoria()
        {
            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
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

                        cmbCategoriaProd.DataSource = dt;
                        cmbCategoriaProd.DisplayMember = "NombreCategoria";
                        cmbCategoriaProd.ValueMember = "CategoriaID";

                        cmbCategoriaProdUp.DataSource = dt;
                        cmbCategoriaProdUp.DisplayMember = "NombreCategoria";
                        cmbCategoriaProdUp.ValueMember = "CategoriaID";
                    }
                }

                connection.Close();
            }
        }
        private void txtNombrePro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            this.CargarcmbCategoria();
            this.cargarDatos();
        }
        private void cargarDatos()
        {
            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryProductos = @"SELECT p.ProductoID, p.NombreProducto, p.Descripcion, p.Precio, p.Stock, c.NombreCategoria
	                                                FROM Productos p
		                                                INNER JOIN  Categorias c
			                                                ON p.CategoriaID = c.CategoriaID;";

                using (SqlCommand cmd = new SqlCommand(queryProductos, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvProductos.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCategoriaProd.SelectedValue.ToString()))
            {
                MessageBox.Show("El campo de categoría esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (string.IsNullOrEmpty(txtNombreProd.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtDescProd.Text))
            {
                MessageBox.Show("El campo de descripción esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtStockProd.Text))
            {
                MessageBox.Show("El campo de stock esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtPrecioProd.Text))
            {
                MessageBox.Show("El campo de precio esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            string nombre = txtNombreProd.Text;
            string descripcion = txtDescProd.Text;
            decimal precio = decimal.Parse(txtPrecioProd.Text);
            int stock = int.Parse(txtStockProd.Text);
            string categoriaID = cmbCategoriaProd.SelectedValue.ToString();


            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryAddProductos = @"INSERT INTO Productos (NombreProducto, Descripcion, Precio, Stock, CategoriaID)
                                           VALUES (@nombreProducto, @descripcion, @precio, @stock, @categoriaID)";


               


                using (SqlCommand cmd = new SqlCommand(queryAddProductos, connection))
                {
                    cmd.Parameters.AddWithValue("@nombreProducto", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = precio;
                    cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                    cmd.Parameters.AddWithValue("@categoriaID", categoriaID);




                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado el producto en la base de datos.");
                        txtNombreProd.Clear();
                        txtDescProd.Clear();
                        txtPrecioProd.Clear();
                        txtStockProd.Clear();
                    
                        cmbCategoriaProd.SelectedIndex = -1;
                    }
                }

                connection.Close();
            }

            this.cargarDatos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtIDProd.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (MessageBox.Show("Recuerde al aceptar eliminar este producto, también se eliminarán los detalles de factura y de compra de dicho producto. Quizás quiera revisarlo antes.", "Advertencia de Eliminación de Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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
                                                WHERE ProductoID IN (
                                                    SELECT ProductoID FROM Productos WHERE ProductoID = @productoIDD
                                                )";
                        using (SqlCommand cmdDetalles = new SqlCommand(deleteDetalles, connection, transaction))
                        {
                            cmdDetalles.Parameters.AddWithValue("@productoIDD", txtIDProd.Text);
                            cmdDetalles.ExecuteNonQuery();
                        }

                        //Eliminar DetallesCompra
                        string deleteDetallesCompra = @"DELETE FROM DetallesCompra WHERE ProductoID = @productoIDC";
                        using (SqlCommand cmdCompras = new SqlCommand(deleteDetallesCompra, connection, transaction))
                        {
                            cmdCompras.Parameters.AddWithValue("@productoIDC", txtIDProd.Text);
                            cmdCompras.ExecuteNonQuery();
                        }

                        //Eliminar Productos
                        string deleteProducto = @"DELETE FROM Productos WHERE ProductoID = @productoID";
                        using (SqlCommand cmdProductos = new SqlCommand(deleteProducto, connection, transaction))
                        {
                            cmdProductos.Parameters.AddWithValue("@productoID", txtIDProd.Text);
                            int rowsAffected = cmdProductos.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Producto eliminado correctamente.");

                                txtIDProd.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el producto.");
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
                this.cargarDatos();

            }
           
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDprodUp.Text))
            {
                MessageBox.Show("El campo de ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (string.IsNullOrEmpty(cmbCategoriaProdUp.SelectedValue.ToString()))
            {
                MessageBox.Show("El campo de categoría esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (string.IsNullOrEmpty(txtNombreProdUp.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtDescProdUp.Text))
            {
                MessageBox.Show("El campo de descripción esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtStockProdUp.Text))
            {
                MessageBox.Show("El campo de stock esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtPrecioProdUp.Text))
            {
                MessageBox.Show("El campo de precio esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }


            string connectionString = @"Data Source=localhost;Initial Catalog=Actividad1;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryUpdateProductos = @"UPDATE Productos 
                                                    SET 
                                                        NombreProducto = @nombre,
                                                        Descripcion = @descripcion,
                                                        Precio = @precio,
                                                        Stock = @stock,
                                                        CategoriaID = @categoriaID

                                                    WHERE ProductoID = @productoID";

                using (SqlCommand cmd = new SqlCommand(queryUpdateProductos, connection))
                {
                    cmd.Parameters.AddWithValue("nombre", txtNombreProdUp.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescProdUp.Text);
                    cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecioProdUp.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtStockProdUp.Text));
                    cmd.Parameters.AddWithValue("@categoriaID", cmbCategoriaProdUp.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@productoID", txtIDprodUp.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha actualizado el producto en la base de datos.");
                        txtNombreProdUp.Clear();
                        txtDescProdUp.Clear();
                        txtPrecioProdUp.Clear();
                        txtStockProdUp.Clear();
                        txtIDprodUp.Clear();
                    }
                }

                connection.Close();
            }

            this.cargarDatos();
        }

        private void txtNombreProd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreProdUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProdUp_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtNombreProdUp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecioProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtStockProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPrecioProdUp_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtStockProdUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtIDProd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIDprodUp_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
