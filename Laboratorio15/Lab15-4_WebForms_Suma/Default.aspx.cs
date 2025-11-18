using System;
public partial class _Default : System.Web.UI.Page {
    protected void btnSumar_Click(object sender, EventArgs e) {
        int n1 = int.Parse(txtNum1.Text);
        int n2 = int.Parse(txtNum2.Text);
        lblResultado.Text = "Resultado: " + (n1+n2);
    }
}
