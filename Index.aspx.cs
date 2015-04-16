using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace IEADWebApp
{
    public partial class Index : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
         }


        protected void ConsultarMemb_Click(object sender, EventArgs e)
        {
            CodMemb.Text = "Toniel Lenk Moraes";
          /*  Response.Write(MessageBox("teste")); */
        }

        private string MessageBox(string p)
            {
 	            return "<script type='text/javascript'> alert("+" '"+ p +"'" + "); </script>";
            }


        protected void Limpar_Clik(object sender, EventArgs e)
        {
            CodMemb.Text = "";
        
        }

        protected void ListMemb(object sender, EventArgs e)
        {
            ConDados teste = new ConDados();
            GridMemb.DataSource = teste.Consulta();
        
        }


    }
}