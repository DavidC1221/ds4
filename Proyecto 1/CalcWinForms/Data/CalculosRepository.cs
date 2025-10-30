using CalcWinForms.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CalcWinForms.Data
{
    public class CalculosRepository
    {
        public void Insert(string expresion, string resultado)
        {
            using (var cn = Db.GetConnection())
            using (var cmd = new SqlCommand("INSERT INTO dbo.Calculos(Expresion, Resultado) VALUES(@e, @r)", cn))
            {
                cmd.Parameters.AddWithValue("@e", expresion);
                cmd.Parameters.AddWithValue("@r", resultado);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Calculo> GetAll()
        {
            var list = new List<Calculo>();
            using (var cn = Db.GetConnection())
            using (var cmd = new SqlCommand("SELECT Id, Expresion, Resultado, Fecha FROM dbo.Calculos ORDER BY Id DESC", cn))
            {
                cn.Open();
                using (var rd = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (rd.Read())
                    {
                        list.Add(new Calculo
                        {
                            Id = rd.GetInt32(0),
                            Expresion = rd.GetString(1),
                            Resultado = rd.GetString(2),
                            Fecha = rd.GetDateTime(3)
                        });
                    }
                }
            }
            return list;
        }
    }
}