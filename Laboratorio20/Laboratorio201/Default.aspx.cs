using System;
using System.Text;

namespace Laboratorio201
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                txtResultado.Text = "Ingrese un número válido.";
                return;
            }

            var sb = new StringBuilder();
            for (int i = 1; i <= 25; i++)
            {
                sb.AppendLine(string.Format("{0} x {1} = {2}", numero, i, numero * i));
            }

            txtResultado.Text = sb.ToString();
        }
    }
}
