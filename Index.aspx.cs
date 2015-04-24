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
           // GridMemb.Columns.Add(new DataColumn("Qty", typeof(String)));
           // GridMemb.Columns.Add(new DataColumn("Item", typeof(String)));
           // GridMemb.Columns.Add(new DataColumn("Price", typeof(String)));
            
         }


        protected void ConsultarMemb_Click(object sender, EventArgs e)
        {
            private int IntCodMemb = Convert.ToInt32(CodMemb.Text);
            ConDados Dados = new ConDados();
            DataTable membros = Dados.Consulta(IntCodMemb);
            if (membros.Rows.Count > 0)
                {             
                GridMemb.DataSource = membros;
                GridMemb.DataBind();
                }
           else {
                Response.Write(MessageBox("Não existe o membro de código:"+IntCodMemb)); 
                }

          /*  Response.Write(MessageBox("teste")); */
        }

        private string MessageBox(string p)
            {
 	            return "<script type='text/javascript'> alert("+" '"+ p +"'" + "); </script>";
            }


        protected void Limpar_Clik(object sender, EventArgs e)
        {
            if (CodMemb.Text != "") {
                 
                CodMemb.Text = "";
            }    
            else
            {
                Response.Write(MessageBox("A Consulta já está Limpa!")); 
            }     
        }

        protected void ListMemb(object sender, EventArgs e)
        {
            ConDados Dados = new ConDados();
            DataTable membros = Dados.Consulta();
            if (membros.Rows.Count > 0)
           {             
                GridMemb.DataSource = membros;
                GridMemb.DataBind();
                //GridMemb.Columns[0].HeaderText = "Release Date";
            }
           else {
                Response.Write(MessageBox("Não existem membros  a serem retornados.")); 
            }
        }

        protected void NovoMemb(object sender, EventArgs e)
        {
            Response.Redirect("CadMemb.aspx");
            
        }

        protected void GridMemb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
