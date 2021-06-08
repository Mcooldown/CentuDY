<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="CentuDY.Views.Transaction.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Transaction History"></asp:Label>
    <asp:GridView ID="gvTransactionHistory" runat="server"></asp:GridView>
    <asp:Label ID="lblGrandTotal" runat="server" Text=""></asp:Label>
</asp:Content>
