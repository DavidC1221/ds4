using System;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio203
{
    public partial class _Default : System.Web.UI.Page
    {
        // Cadena de conexión basada en tu servidor CORDOBA y base de datos Productos
        string connectionString = @"Server=CORDOBA;Database=productos;Trusted_Connection=True;";
        bool nuevo
        {
            get { return (bool?)ViewState["nuevo"] ?? false; }
            set { ViewState["nuevo"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EstadoInicial();
            }
        }

        private void EstadoInicial()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;

            txtId.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;

            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            lblMensaje.Text = "";
            nuevo = false;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = false;

            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;

            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            lblMensaje.Text = "";
            nuevo = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int id;
            decimal precio;
            int stock;

            if (!int.TryParse(txtId.Text, out id) ||
                !decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtStock.Text, out stock))
            {
                lblMensaje.Text = "Verifique los datos numéricos (Id, Precio, Stock).";
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();

                if (nuevo)
                {
                    cmd.CommandText = "INSERT INTO Laptops (Id, Nombre, Precio, Stock) " +
                                      "VALUES (@Id, @Nombre, @Precio, @Stock)";
                }
                else
                {
                    cmd.CommandText = "UPDATE Laptops SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock " +
                                      "WHERE Id=@Id";
                }

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        lblMensaje.Text = nuevo
                            ? "Registro ingresado correctamente."
                            : "Registro actualizado correctamente.";
                    }
                    else
                    {
                        lblMensaje.Text = "No se afectó ningún registro.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }

            EstadoInicial();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                lblMensaje.Text = "Ingrese un Id válido para eliminar.";
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Laptops WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        lblMensaje.Text = "Registro eliminado correctamente.";
                    }
                    else
                    {
                        lblMensaje.Text = "No se encontró un registro con ese Id.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }

            EstadoInicial();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                lblMensaje.Text = "Ingrese un Id válido para buscar.";
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre, Precio, Stock FROM Laptops WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtId.Text = reader["Id"].ToString();
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtPrecio.Text = reader["Precio"].ToString();
                        txtStock.Text = reader["Stock"].ToString();

                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnBuscar.Enabled = false;

                        txtId.Enabled = false;
                        txtNombre.Enabled = true;
                        txtPrecio.Enabled = true;
                        txtStock.Enabled = true;

                        nuevo = false;
                        lblMensaje.Text = "Registro encontrado. Puede actualizar o eliminar.";
                    }
                    else
                    {
                        lblMensaje.Text = "Ningún registro encontrado con el Id ingresado.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }
        }
    }
}
