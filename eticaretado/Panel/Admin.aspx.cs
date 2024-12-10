using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace eticaretado.Panel
{
    public partial class Admin1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=MURATMEB\\SQLEXPRESS;Initial Catalog=eticaretdb;Integrated Security=True;");
        //database bağlantısını oluşturuyor
        protected void Page_Load(object sender, EventArgs e)
        {
            doldur();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into admin (kuser,kpass) values (@user,@pass) ";
            //sql kayıt ekleme cümlesi
            conn.Open();

            SqlCommand cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            cmd.ExecuteNonQuery();
            Response.Write("Kayıt Eklendi");
            doldur();

            conn.Close();

        }
        private void doldur()
        {
            string sorgu = "Select * from Admin";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
            DataTable tb=new DataTable();
            da.Fill(tb);
            GridView1.DataSource = tb;
            GridView1.DataBind();

        }
    }
}