using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Runtime.CompilerServices;
namespace eticaretado.Panel
{
    public partial class Product : System.Web.UI.Page
    {
        Database yeni=new Database();   
        protected void Page_Load(object sender, EventArgs e)
        {
            doldur();
            acilandoldur();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string folderpath = Server.MapPath("../ProductImage/");
            if(!Directory.Exists(folderpath))
            {
                Response.Write("Klasör mevcut Değil");
            }
            else
            {
               if(PrPicture.HasFile)
                {
                    string dosyaAdi=Path.GetFileName(PrPicture.FileName);
                    string dosyauzanti=Path.GetExtension(PrPicture.FileName);
                    byte[]boyut=PrPicture.FileBytes;
                    Guid rast =Guid.NewGuid();
                    string yeniad=rast+"."+dosyauzanti;
                    //Response.Write(yeni);
                    //Response.Write(dosyaAdi);
                    //Response.Write(dosyauzanti);
                    //Response.Write(boyut);
                    PrPicture.SaveAs(folderpath + "/" + yeniad);
                    string soru = "insert into Product (ProductName,CategoryId,ProductPrice,ProductPicture,ProductStock) values ('" + TextBox1.Text + "','" + CategoryDrop.SelectedValue + "','" + productPrice.Text + "','" + yeniad + "','" + ProductStock.Text + "')";

                    yeni.Sorgu(soru);
                    doldur();
                }
            }
        }
        void doldur()
        {
            string cumle = "Select * from product";
            GridView1.DataSource = yeni.tabloveri(cumle);
            GridView1.DataBind();
        }
        void acilandoldur()
        {
            string cumlek = "Select CategoryId,CategoryName from Category";
            CategoryDrop.DataSource = yeni.tabloveri(cumlek);
            CategoryDrop.DataTextField = "CategoryName";
            CategoryDrop.DataValueField = "CategoryId";

            CategoryDrop.DataBind();
            

        }
    }
}