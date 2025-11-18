
using System;
using System.Web.UI;

namespace Laboratorio16
{
    public partial class WebForm1 : Page
    {
        static float valor1 = 0;
        static char op = ' ';

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Digit_Click(object sender, EventArgs e)
        {
            var btn = (System.Web.UI.WebControls.Button)sender;
            txtDisplay.Text += btn.Text;
        }

        protected void Op_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                valor1 = float.Parse(txtDisplay.Text);
                var btn = (System.Web.UI.WebControls.Button)sender;
                op = btn.Text[0];
                txtDisplay.Text = "";
            }
        }

        protected void btnEq_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;

            float valor2 = float.Parse(txtDisplay.Text);
            float resultado = 0;

            switch (op)
            {
                case '+':
                    resultado = valor1 + valor2;
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    break;
                case '*':
                    resultado = valor1 * valor2;
                    break;
                case '/':
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                        txtDisplay.Text = "Error";
                    break;
            }

            if (txtDisplay.Text != "Error")
                txtDisplay.Text = resultado.ToString();
        }

        protected void btnClr_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            valor1 = 0;
            op = ' ';
        }
    }
}
