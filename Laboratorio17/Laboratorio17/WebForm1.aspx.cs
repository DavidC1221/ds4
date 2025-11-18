
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Laboratorio17
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            ConnectionStringSettings constring = ConfigurationManager.ConnectionStrings["db.Name"];
            using (SqlConnection conexion = new SqlConnection(constring.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SalesByCategory", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = "Seafood";

                conexion.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        GridView1.DataSource = reader;
                        GridView1.DataBind();
                    }
                }
            }
        }
    }
}
