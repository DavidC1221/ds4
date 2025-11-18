using System;
public partial class _Default : System.Web.UI.Page {
    protected void Button1_Click(object sender, EventArgs e) {
        string texto = TextBox1.Text;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "msg", "alert('Hola: " + texto + "');", true);
    }
}
