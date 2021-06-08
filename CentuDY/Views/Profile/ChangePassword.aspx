<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CentuDY.Views.Profile.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label  runat="server" Text="CHANGE PASSWORD"></asp:Label>
    <br />
    
    <asp:Label ID="lblOldPassword" runat="server" Text="Old Password: "></asp:Label>
    <asp:TextBox ID="valOldPassword" runat="server"></asp:TextBox>
    <br />
    
    <asp:Label ID="lblNewPassword" runat="server" Text="New Password: "></asp:Label>
    <asp:TextBox ID="valNewPassword" runat="server"></asp:TextBox>
    <br />
    
    <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm New Password: "></asp:Label>
    <asp:TextBox ID="valConfirmPassword" runat="server"></asp:TextBox>
    <br />
    
    <asp:Label ID="lblMessage" style="color:red;" runat="server" Text=""></asp:Label>
    <br />
    
    <asp:Button ID="btnUpdatePassword" runat="server" Text="UPDATE" CommandArgument='<%= user.userId %>' onClick="btnUpdatePassword_Click"/>
</asp:Content>
