using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eticaretado.Panel
{
    public partial class Category_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Database yeni=new Database();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt16(Request.QueryString["id"]);
            string sorgu = "Delete from Category Where CategoryId='" + id+"'";
            yeni.Sorgu(sorgu);
            Response.Redirect("Kategori.aspx");


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Kategori.aspx");
        }
    }
}