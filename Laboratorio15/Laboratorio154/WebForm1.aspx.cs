using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String numero1 = TextBox1.Text;
            String numero2 = TextBox2.Text;
            try
            {
                String suma = (Convert.ToDouble(numero1) + Convert.ToDouble(numero2)).ToString();
                Label4.Text += suma;
            }
            catch (Exception ex)
            {
                Label4.Text = "Error en sumar los números.";
            }
        }
    }
}