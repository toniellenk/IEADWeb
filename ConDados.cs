using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace IEADWebApp
{
    public class ConDados
    {

        string SrtCon = ConfigurationManager.ConnectionStrings["root"].ConnectionString;
        string StrSelect = "SELECT * FROM t0050";
        protected DataSet ds = new DataSet();
        protected DataTable dt = new DataTable();

        public DataTable Consulta() { 
        
                /*Cria o objeto de conexão com o banco */
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                /*Cria o objeto de execução do comando */
                SqlCommand ObjCmd = new SqlCommand(StrSelect, ObjConn);
                /*Executa o comando*/
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                /*Abre a conexão */
                ObjConn.Open();                                
                da.Fill(ds);
                ObjConn.Close();
                dt = ds.Tables[0];
                return dt;
        }


        public string nome {
            get { return SrtCon; }
        }
    }
}
