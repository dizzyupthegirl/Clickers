<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Default2.aspx.vb" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">



    Department Name
    <asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox>
    <asp:Button ID="btnAdd" runat="server" Text="Add Department" />
    <br />
    <br />
    <br />
    <br />
    Departments<br />
    <asp:ListBox ID="lstDepartments" runat="server" Height="291px" Width="277px">
    </asp:ListBox>
    <br />
    <asp:Button ID="btnDeleteDepartment" runat="server" Text="Delete Department" />
    <asp:Button ID="btnToggleActive" runat="server" Text="Toggle Active" />
&nbsp;



</asp:Content>