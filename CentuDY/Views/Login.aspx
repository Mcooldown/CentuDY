<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CentuDY.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label runat="server" Text="Login - CentuDY"></asp:Label>
    <br />
    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="valUsername" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="valPassword" runat="server"></asp:TextBox>
    <br />
    <asp:CheckBox ID="cbCookie" Text="Remember Me" runat="server" />
    <br />
    <asp:Label ID="lblMessage" runat="server" Text="" style="color:red;"></asp:Label>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="btnLogin_Click" />
    <br />
    Not have an account? <asp:Button ID="btnRegister" runat="server" Text="REGISTER" OnClick="btnRegister_Click" />
</asp:Content>
