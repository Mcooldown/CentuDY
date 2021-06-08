<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="CentuDY.Views.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblUser" runat="server" Text="VIEW USER"></asp:Label>
    <br />
    <asp:GridView ID="gvUser" runat="server">
         <Columns>
               <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandArgument='<%# Eval("UserId") %>' ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
                        </ItemTemplate>
               </asp:TemplateField>
         </Columns>
    </asp:GridView>
</asp:Content>
