<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Admin.Master" AutoEventWireup="true" CodeBehind="Product_Delete.aspx.cs" Inherits="eticaretado.Panel.Product_Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:Button ID="Button1" CssClass="btn btn-danger" runat="server" Height="34px" Text="Silme" Width="71px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="btn btn-success" runat="server" Height="34px" Text="İptal" Width="73px" OnClick="Button2_Click" />
    </form>
</asp:Content>
