<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="UpdateMedicine.aspx.cs" Inherits="CentuDY.Views.Medicine.UpdateMedicine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblMedicine" runat="server" Text="UPDATE MEDICINE"></asp:Label>
    
    <br />
    <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
    <asp:TextBox ID="valName" runat="server"></asp:TextBox>
     <br />
    <asp:Label ID="lblDescription" runat="server" Text="Description: "></asp:Label>
    <asp:TextBox ID="valDescription" runat="server"></asp:TextBox>
     <br />
    <asp:Label ID="lblStock" runat="server" Text="Stock: "></asp:Label>
    <asp:TextBox ID="valStock" runat="server"></asp:TextBox>
     <br />
    <asp:Label ID="lblPrice" runat="server" Text="Price: "></asp:Label>
    <asp:TextBox ID="valPrice" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMessage" runat="server" Text="" style="color:red;"></asp:Label>   
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />

</asp:Content>
