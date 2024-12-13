<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Admin.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="eticaretado.Panel.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form runat="server" enctype="multipart/form-data">
  <div class="form-group row">
    <label for="CategoryName" class="col-4 col-form-label">Ürün Adı</label> 
    <div class="col-8">
        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
   
  </div> 

<div class="form-group row">
  <label for="CategoryName" class="col-4 col-form-label">Kategori Adı</label> 
  <div class="col-8">
      <asp:DropDownList ID="CategoryDrop" class="form-control" runat="server"></asp:DropDownList>
  </div>
 
</div> 

<div class="form-group row">
  <label for="CategoryName" class="col-4 col-form-label">Ürün Fiyatı</label> 
  <div class="col-8">
      <asp:TextBox ID="productPrice" runat="server"></asp:TextBox>
  </div>
 
</div> 

<div class="form-group row">
  <label for="CategoryName" class="col-4 col-form-label">Ürün Resmi</label> 
  <div class="col-8">
      <asp:FileUpload ID="PrPicture" class="form-control" runat="server"></asp:FileUpload>
  </div>
 
</div> 

<div class="form-group row">
  <label for="CategoryName" class="col-4 col-form-label">Stok Durumu</label> 
  <div class="col-8">
      <asp:TextBox ID="ProductStock" runat="server"></asp:TextBox>
  </div>
 
</div> 

  <div class="form-group row">
    <div class="offset-4 col-8">
        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server" Width="242px">
            <Columns>
                <asp:TemplateField HeaderText="Düzeltme">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("ProductId", "Product_Edit.aspx?id={0}") %>' Text='<%# Eval("ProductId", "Düzelt") %>'></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="Product_Delete.aspx?id={0}" DataTextField="ProductId" DataTextFormatString="Silme" HeaderText="Silme" Text="Silme" />
            </Columns>
        </asp:GridView>
    </div>
  </div>
</form>





</asp:Content>
