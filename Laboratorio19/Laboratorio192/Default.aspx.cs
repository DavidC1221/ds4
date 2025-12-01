using System;
using System.IO;
using System.Net;

namespace Laboratorio192
{
    public partial class _Default : System.Web.UI.Page
    {
        // Cambia este URL para que apunte a tu API real (Lab 19-1)
        private const string baseUrl = "https://localhost:44372";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGetAll_Click(object sender, EventArgs e)
        {
            string json = GetItems();
            txtResultado.Text = json;
        }

        private string GetItems()
        {
            string url = baseUrl + "/api/items"; // Ajusta la ruta real de tu API

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
