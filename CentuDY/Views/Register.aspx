<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CentuDY.Views.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <asp:Label runat="server" Text="REGISTER - CentuDY"></asp:Label>
    <br />

    <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
    <asp:TextBox ID="valUsername" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
    <asp:TextBox ID="valPassword" runat="server"></asp:TextBox>
    <br />
     <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password: "></asp:Label>
    <asp:TextBox ID="valConfirmPassword" runat="server"></asp:TextBox>
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
    
    <asp:Button ID="btnRegister" runat="server" Text="REGISTER" onClick="btnRegister_Click" />

    <br />
    Already have an account? <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="btnLogin_Click" />

</asp:Content>
