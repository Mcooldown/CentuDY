<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="CentuDY.Views.Cart.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblCart" runat="server" Text="VIEW CART"></asp:Label>
    <br />
    <asp:GridView ID="gvCart" runat="server">
        <Columns>
               <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandArgument='<%# Eval("MedicineId") %>' ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
         </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="lblGrandTotal" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblMessage" runat="server" Text="" style="color:red;"></asp:Label>
    <br />
    <asp:Button ID="btnCheckout" runat="server" Text="CHECKOUT" OnClick="btnCheckout_Click" />
</asp:Content>
