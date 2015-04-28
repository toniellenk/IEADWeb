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
        protected DataSet ds = new DataSet();
        protected DataTable dt = new DataTable();

        public DataTable Consulta() { 
            
                string SqlSelect = "select * from t0050";
                /*Cria o objeto de conexão com o banco */
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                /*Cria o objeto de execução do comando */
                SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);
                ObjConn.Open();   
                /*Executa o comando*/
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                /*Abre a conexão */
                da.Fill(ds);
                dt = ds.Tables[0];
                ObjConn.Close();
                return dt;
        }

                
                public DataTable Consulta(int idmembro) { 
                    
                /*Query SQL*/    
                private string SqlSelect = "select * from t0050 where idmembro = @idmembro";
               
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);
                
                /*Definição de parãmetros da Query */
                ObjCmd.Parameters.AddWithValue("@idmembro", idmembro)
                
                ObjConn.Open();   
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                da.Fill(ds);
                dt = ds.Tables[0];
                ObjConn.Close();
                return dt;
        }
        
        public void inserir(string nome,string sexo,string tel,string end,string uf,string cid,string cep,string tip)
            {
                private SqlInsert = "insert into t0050(nome, sexo, tel, end, uf, cid, cep, tip) values(@nome, @sexo, @tel, @end, @uf, @cid, @cep, @tip)";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCmd(ObjConn, SqlInsert);
                
                ObjCmd.Parameters.AddWithValue("@nome",nome);
                ObjCmd.Parameters.AddWithValue("@sexo",sexo);
                ObjCmd.Parameters.AddWithValue("@tel",tel);
                ObjCmd.Parameters.AddWithValue("@end",tel);
                ObjCmd.Parameters.AddWithValue("@uf",uf);
                ObjCmd.Parameters.AddWithValue("@cid",cid);
                ObjCmd.Parameters.AddWithValue("@cep",cep);
                ObjCmd.Parameters.AddWithValue("@tip",tip);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery;
                
                ObjConn.Close();
            }
        
        public string nome {
            get { return SrtCon; }
        }
    }
}
