
using System;
using System.Web.UI;

namespace Laboratorio17
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSourceID = "SqlDataSource1";
        }
    }
}
