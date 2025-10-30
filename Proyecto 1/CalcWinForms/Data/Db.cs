using System.Configuration;
using System.Data.SqlClient;

namespace CalcWinForms.Data
{
    public static class Db
    {
        public static SqlConnection GetConnection()
        {
            var cs = ConfigurationManager.ConnectionStrings["CalcDb"].ConnectionString;
            return new SqlConnection(cs);
        }
    }
}