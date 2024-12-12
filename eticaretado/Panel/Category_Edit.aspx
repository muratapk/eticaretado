<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Admin.Master" AutoEventWireup="true" CodeBehind="Category_Edit.aspx.cs" Inherits="eticaretado.Panel.Category_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form runat="server">
  <div class="form-group row">
    <label for="CategoryName" class="col-4 col-form-label">Kategori Adı</label> 
    <div class="col-8">
        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
  </div> 
  <div class="form-group row">
    <div class="offset-4 col-8">
        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="301px">
            <Columns>
                <asp:BoundField DataField="CategoryName" HeaderText="Kategori Adı" />
                <asp:HyperLinkField DataNavigateUrlFields="CategoryId" DataNavigateUrlFormatString="Category_Delete.aspx?id={0}" DataTextField="CategoryId" DataTextFormatString="Silme" HeaderText="Silme" Text="Silme" />
                <asp:HyperLinkField DataNavigateUrlFields="CategoryId" DataNavigateUrlFormatString="Category_Edit.aspx?id={0}" DataTextField="CategoryId" DataTextFormatString="Düzelt" HeaderText="Düzelt" Text="Düzelt" />
            </Columns>
        </asp:GridView>
    </div>
  </div>
</form>



</asp:Content>
