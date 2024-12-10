<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Edit.aspx.cs" Inherits="eticaretado.Panel.Admin_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Düzeltme</h1>
        <div class="container">
        <div class="row">
            <div class="col-md-8">
 <form runat="server">
  <div class="form-group row">
    <label for="kuser" class="col-4 col-form-label">Kullanıcı Adı</label> 
    <div class="col-8">
        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
  </div>
  <div class="form-group row">
    <label for="kpass" class="col-4 col-form-label">Şifrenizi Girin</label> 
    <div class="col-8">
        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
  </div> 
  <div class="form-group row">
    <div class="offset-4 col-8">
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Düzelt" OnClick="Button1_Click" />
    </div>
  </div>


     &nbsp;<asp:GridView ID="GridView1" runat="server" Width="333px" CssClass="table table-striped" AutoGenerateColumns="False">
         <Columns>
             <asp:BoundField DataField="kuser" HeaderText="Kullanıcı Adı" />
             <asp:BoundField DataField="kpass" HeaderText="Şifre" />
             <asp:HyperLinkField DataNavigateUrlFields="AdminId" DataNavigateUrlFormatString="Admin_Edit.aspx?Id={0}" DataTextField="AdminId" DataTextFormatString="Düzelt" HeaderText="Düzeltme" Text="Düzeltme" />
             <asp:HyperLinkField DataNavigateUrlFields="AdminId" DataNavigateUrlFormatString="Admin_Sil.aspx?Id={0}" DataTextField="AdminId" DataTextFormatString="Silme" HeaderText="Silme" Text="Silme" />
         </Columns>
     </asp:GridView>
</form>

            </div>
        </div>

    </div>
</asp:Content>
