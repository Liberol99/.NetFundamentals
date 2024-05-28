<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BogusFakeData._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%
        if (customerData != null && customerData.Count() > 0)
        {
            foreach (var item in customerData)
            {
                %><p class="display-6 text-primary d-inline-block me-3"><%= item.Name %></p><%
                %><p class="display-6 text-danger d-inline-block"><%= item.Email %></p><br /><%
            }
        }
    %>
</asp:Content>