using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IEADWebApp 
{
 public partial class CadMemb : System.Web.UI.Page
 {
  protected void Page_Load(object sender, EventArgs e)
   {
    }

  protected void NovoMemb(object sender, EventArgs e)
  {
      private string nome = NomeMemb.Text;
      private string sexo = SexMemb.Text;
      private string tel = TelMemb.Text;
      private string end = EndMemb.Text;
      private string uf = UfMemb.Text;
      private string cid = CidMemb.Text;
      private string cep = CepMemb.Text;
      private string tip = TipMemb.Text;
      
      ConDados InsDados = new ConDados();
      InsDados.Inserir(nome, sexo, tel, end, uf, cid, cep, tip);
  }

  // public void Novomemb() { 
   // NomeMemb.Text = 'Toniel Lenk';}
  
 }
}
