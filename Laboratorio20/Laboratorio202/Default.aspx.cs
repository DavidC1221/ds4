using System;
using System.Text;

namespace Laboratorio202
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtN.Text, out n) || n <= 0)
            {
                ltMatriz.Text = "Ingrese un valor válido para N (entero positivo).";
                return;
            }

            var sb = new StringBuilder();
            sb.Append("<table border='1' cellspacing='0' cellpadding='4'>");

            for (int i = 0; i < n; i++)
            {
                sb.Append("<tr>");
                for (int j = 0; j < n; j++)
                {
                    int valor = (j == (n - 1 - i)) ? 1 : 0;
                    sb.Append("<td style='text-align:center;'>");
                    sb.Append(valor);
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }

            sb.Append("</table>");
            ltMatriz.Text = sb.ToString();
        }
    }
}
