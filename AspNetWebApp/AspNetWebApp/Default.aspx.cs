using System;
using System.Web.UI;

namespace AspNetWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Employee tablosunda" + " " + About.sayac.ToString()+" "+ "kayıt var.";
        }
    }
}