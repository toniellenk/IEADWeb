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
        
        
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(StrSelect, ObjConn);
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
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