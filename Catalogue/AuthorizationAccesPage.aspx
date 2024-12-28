<%@ Page Title="" Language="C#" MasterPageFile="~/NavBar.Master" AutoEventWireup="true" CodeBehind="AuthorizationAccesPage.aspx.cs" Inherits="Catalogue.AuthorizationAccesPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>


    <a href="Login.aspx">Go login</a>

</asp:Content>
