using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eticaretado.Panel
{
    public partial class Category_Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack==false)
            {
                int id = Convert.ToInt16(Request.QueryString["id"]);
                string cumle = "Select * from Category where CategoryId='" + id + "'";
                SqlDataReader dr = yeni.okuma(cumle);
                TextBox1.Text = dr[1].ToString();
            }
              

        }
        Database yeni = new Database();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
         string cumle = "Update Category set CategoryName='" + TextBox1.Text + "' where CategoryId='" + id + '"';
            yeni.Sorgu(cumle);
            doldur();
        }
        public void doldur()
        {
            string cumle = "select * from Category";
            GridView1.DataSource = yeni.tabloveri(cumle);
            GridView1.DataBind();
        }
    }
}