<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="CentuDY.Views.Cart.AddToCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="lblTitle" runat="server" Text="ADD TO CART"></asp:Label>
    <br />
    Name: <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
    <br />
    Description: <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label>
    <br />
    Stock: <asp:Label ID="lblStock" runat="server" Text=""></asp:Label>
    <br />
    Price: <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
    <asp:TextBox ID="valQuantity" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMessage" style="color:red;" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnAdd" runat="server" Text="ADD TO CART" OnClick="btnAdd_Click" />
</asp:Content>
