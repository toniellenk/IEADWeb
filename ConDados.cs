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
        string StrSelect = "select * from t0050";
        protected DataSet ds = new DataSet();
        protected DataTable dt = new DataTable();

        public DataTable Consulta() { 
        
                /*Cria o objeto de conexão com o banco */
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                /*Cria o objeto de execução do comando */
                SqlCommand ObjCmd = new SqlCommand(StrSelect, ObjConn);
                ObjConn.Open();   
                /*Executa o comando*/
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                /*Abre a conexão */
                da.Fill(ds);
                dt = ds.Tables[0];
                ObjConn.Close();
                return dt;
        }


        public string nome {
            get { return SrtCon; }
        }
    }
}
