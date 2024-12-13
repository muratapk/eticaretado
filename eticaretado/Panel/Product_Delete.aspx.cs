using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eticaretado.Panel
{
    public partial class Product_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Database db= new Database();    
        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            string cumle = "Delete from where ProductId=" + id;
            db.Sorgu(cumle);
            Response.Redirect("Product.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }
    }
}