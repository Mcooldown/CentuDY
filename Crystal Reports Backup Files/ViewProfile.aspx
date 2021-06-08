<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="CentuDY.Views.Profile.ViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" Text="PROFILE"></asp:Label>
    <br />
    Username: <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
    <br />
    Name: <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
    <br />
    Gender: <asp:Label ID="lblGender" runat="server" Text=""></asp:Label>
    <br />
    Phone Number: <asp:Label ID="lblPhoneNumber" runat="server" Text=""></asp:Label>
    <br />
    Address: <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnUpdateProfile" runat="server" Text="UPDATE PROFILE" OnClick="btnUpdateProfile_Click"  />
    <asp:Button ID="btnChangePassword" runat="server" Text="CHANGE PASSWORD" OnClick="btnChangePassword_Click"/>

</asp:Content>
