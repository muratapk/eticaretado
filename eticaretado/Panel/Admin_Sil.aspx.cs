using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eticaretado.Panel
{
    public partial class Admin_Sil : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=MURATMEB\\SQLEXPRESS;Initial Catalog=eticaretdb;Integrated Security=True;");
        //database bağlantısını oluşturuyor
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Id =Convert.ToInt16( Request.QueryString["id"]);
            string sorgu = "Delete from Admin where AdminId=@Id";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
            Response.Write("Kayıt Silindi");
            conn.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}