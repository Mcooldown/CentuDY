<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="CentuDY.Views.Profile.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label runat="server" Text="UPDATE PROFILE"></asp:Label>
    <br />

     <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
    <asp:TextBox ID="valName" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
    <asp:RadioButton ID="valGenderMale" GroupName="gender" runat="server" Text="Male" />
    <asp:RadioButton ID="valGenderFemale" GroupName="gender" runat="server" Text="Female" />
    <br />

    <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number: "></asp:Label>
    <asp:TextBox ID="valPhoneNumber" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblAddress" runat="server" Text="Address: "></asp:Label>
    <asp:TextBox ID="valAddress" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblMessage" style="color:red;" runat="server" Text=""></asp:Label>
    <br />
    
    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
</asp:Content>
