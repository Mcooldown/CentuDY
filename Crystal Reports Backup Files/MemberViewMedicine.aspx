<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="MemberViewMedicine.aspx.cs" Inherits="CentuDY.Views.Medicine.MemberViewMedicine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMedicine" runat="server" Text="VIEW MEDICINES"></asp:Label>
    <br />
    <asp:GridView ID="gvMedicine" runat="server">
        <Columns>
               <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandArgument='<%# Eval("MedicineId") %>' ID="btnAddToCart" runat="server" Text="ADD TO CART" OnClick="btnAddToCart_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
         </Columns>
    </asp:GridView>
</asp:Content>
