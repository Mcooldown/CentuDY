<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="AdminViewMedicine.aspx.cs" Inherits="CentuDY.Views.Medicine.ViewMedicine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMedicine" runat="server" Text="VIEW MEDICINES"></asp:Label>
    <br />
    <asp:Button ID="btnInsert" runat="server" Text="INSERT" OnClick="btnInsert_Click" />
    <br />
    <asp:GridView ID="gvMedicine" runat="server">
        <Columns>
               <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandArgument='<%# Eval("MedicineId") %>' ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandArgument='<%# Eval("MedicineId") %>' ID="btnDelete" runat="server" Text="DELETE" Onclick="btnDelete_Click" />
                        </ItemTemplate>
                </asp:TemplateField>
         </Columns>
    </asp:GridView>
</asp:Content>
