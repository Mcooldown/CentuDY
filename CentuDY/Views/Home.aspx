<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CentuDY.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    Welcome <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
    <br />

    <asp:Button ID="btnProfile" runat="server" Text="VIEW PROFILE" OnClick="btnProfile_Click" />

    
    <% if (user.RoleId == 2)
        { %>
    <asp:Button ID="btnMemberMedicine" runat="server" Text="VIEW MEDICINES" OnClick="btnMemberMedicine_Click"  />    
    <asp:Button ID="btnCart" runat="server" Text="VIEW CART" OnClick="btnCart_Click" />
    <asp:Button ID="btnHistory" runat="server" Text="VIEW TRANSACTION HISTORY" OnClick="btnHistory_Click" />
    <% } %>

     <% if (user.RoleId == 1){ %>
    <asp:Button ID="btnAdminMedicine" runat="server" Text="VIEW MEDICINES" Onclick="btnAdminMedicine_Click" />
    <asp:Button ID="btnInsertMedicine" runat="server" Text="INSERT MEDICINE" OnClick="btnInsertMedicine_Click" />
    <asp:Button ID="btnUser" runat="server" Text="VIEW USERS" OnClick="btnUser_Click" />
    <asp:Button ID="btnReport" runat="server" Text="VIEW TRANSACTION REPORT" OnClick="btnReport_Click" />
    <% } %>

    <asp:Button ID="btnLogout" runat="server" Text="LOGOUT" OnClick="btnLogout_Click" />
</asp:Content>
