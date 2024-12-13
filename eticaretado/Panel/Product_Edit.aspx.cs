using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eticaretado.Panel
{
    public partial class Product_Edit : System.Web.UI.Page
    {
        Database db = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                string cumle = "Select * from Product Where ProductId=" + id;
                SqlDataReader dr = db.okuma(cumle);
                while(dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    productPrice.Text= dr[2].ToString();
                    CategoryDrop.Text = dr[3].ToString();
                    ProductStock.Text = dr[5].ToString();
                    Image1.Attributes["src"] ="../ProductImage/"+ dr[4].ToString();
                }
                db._conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}