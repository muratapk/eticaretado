using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace eticaretado
{
    public class Database
    {
        private static string baglanti = "Data Source=.\\SQLEXPRESS;Initial Catalog=eticaretdb;Integrated Security=True;";
        public SqlConnection _conn=new SqlConnection(baglanti);
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable td;
        public SqlDataReader dr;
        public Database()
        {
            
        }
        public void Sorgu(string cumle)
        {
            _conn.Open();
            cmd = new SqlCommand(cumle,_conn);
            cmd.ExecuteNonQuery();

            _conn.Close();
        }
        public DataTable tabloveri(string cumle)
        {
            da=new SqlDataAdapter(cumle,_conn);
            td=new DataTable();
            da.Fill(td);
            return td;
        }
        public void Add(string tablo,string kolonlar,string veriler)
        {
            string cumle = "insert into " + tablo + "(" + kolonlar + ") values ('" + veriler + "')";
            this.Sorgu(cumle);
        }
        public SqlDataReader okuma(string cumle)
        {
            _conn.Open();
            cmd=new SqlCommand(cumle, _conn);
            dr=cmd.ExecuteReader();
            
          
            return dr;
            
        }
    }
}