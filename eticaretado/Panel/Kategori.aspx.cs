using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eticaretado.Panel
{
    public partial class Kategori : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            doldur();
        }
        Database yeni = new Database();
        protected void Button1_Click(object sender, EventArgs e)
        {
            //string sorgu = "insert into Category (CategoryName) values ('"+TextBox1.Text+"')";
            //yeni.Sorgu(sorgu);
            string tablo = "Category";
            string kolonlar = "CategoryName";
            string veriler = TextBox1.Text;
            yeni.Add(tablo, kolonlar, veriler);

            doldur();
        }
        public void doldur()
        {
            string cumle = "Select * from Category";
            GridView1.DataSource = yeni.tabloveri(cumle);
            GridView1.DataBind();
        }
    }
}