using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    MessageBox.Show("Se abrió la conexión con SQL Server y se seleccionó Northwind.",
                        "Conexión OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarProductos(conexion);

                    conexion.Close();
                    MessageBox.Show("Se cerró la conexión.",
                        "Conexión cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos(SqlConnection conexion)
        {
            lstProductos.Items.Clear();

            using (SqlCommand cmd = new SqlCommand(
                "SELECT ProductName FROM dbo.Products ORDER BY ProductName;", conexion))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                    lstProductos.Items.Add(rd.GetString(0));
            }

            if (lstProductos.Items.Count == 0)
                lstProductos.Items.Add("(Sin productos encontrados)");
        }
    }
}
