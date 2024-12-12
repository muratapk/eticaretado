using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eticaretado.Panel
{
    public partial class Admin_Edit : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eticaretdb;Integrated Security=True;");
        //database bağlantısını oluşturuyor
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack==false)
                {
                int Id = Convert.ToInt32(Request.QueryString["Id"]);
                string sorgu = "Select * from Admin where AdminId=@Id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("Id", Id);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                }
                conn.Close();



            }
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sorgu = "update admin set kuser=@user,kpass=@pass where AdminId=@Id ";
            //sql kayıt ekleme cümlesi
            conn.Open();
            int Id = Convert.ToInt32(Request.QueryString["Id"]);
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
            Response.Write("Kayıt Eklendi");
            

            conn.Close();
        }
    }
}