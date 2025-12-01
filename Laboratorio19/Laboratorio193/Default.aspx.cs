using System;
using System.IO;
using System.Net;

namespace Laboratorio193
{
    public partial class _Default : System.Web.UI.Page
    {
        // Mismo URL base del Web API (Lab 19-1)
        private const string baseUrl = "https://localhost:44372";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGetById_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                txtResultado.Text = "ID inválido.";
                return;
            }

            string json = GetItem(id);
            txtResultado.Text = json;
        }

        private string GetItem(int id)
        {
            string url = baseUrl + "/api/items/" + id; // Ajusta la ruta real

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            return responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return "Error al consumir API: " + ex.Message;
            }
        }
    }
}
