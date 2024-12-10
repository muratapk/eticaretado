<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Sil.aspx.cs" Inherits="eticaretado.Panel.Admin_Sil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Silme</h1>
     <div class="container">
         <div class="row">
             <div class="col-md-8">
                 <div class="alert alert-danger" role="alert">
                  Bu Kaydı Silmek İstiyor musunuz?
                     
                 </div>
                 <form runat="server">
                 <asp:Button ID="Button1" runat="server" CssClass="btn btn-danger" Text="Sil" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" CssClass="btn btn-gray" Text="İptal" OnClick="Button2_Click" />
                 </form>
             </div>
         </div>
     </div>
</asp:Content>
