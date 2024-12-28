<%@ Page Title="" Language="C#" MasterPageFile="~/NavBar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Catalogue.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="lblPass" runat="server" Text="Pass"></asp:Label>
<asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button ID="btnLogin" runat="server" Text="Sign In"  OnClick="btnLogin_Click" />
    </div>

</asp:Content>
