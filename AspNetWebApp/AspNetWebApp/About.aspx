<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AspNetWebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1">
        <asp:TextBox ID="Id" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="FirstName" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="LastName" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="Age" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>

    <asp:Table ID="Table1" runat="server" CssClass="table table-striped"></asp:Table>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    <%
        if (employees != null && employees.Count() > 0)
        {
            foreach (var item in employees)
            {
                %><p><%=item.FirstName%></p><%
            }
        }
    %>

</asp:Content>
