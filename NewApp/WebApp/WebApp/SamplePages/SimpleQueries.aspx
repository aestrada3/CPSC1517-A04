<%@ Page Title="Simple Queries" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleQueries.aspx.cs" Inherits="WebApp.SamplePages.SimpleQueries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Simple Queries</h1>
    <table align="center" style="width: 80%">
        <tr>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Enter Product ID:"></asp:Label><asp:TextBox ID="SearchArg" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Product ID:"></asp:Label><asp:Label ID="ProductID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /><asp:Button ID="Clear" runat="server" Text="Clear" CausesValidation="false" OnClick="Clear_Click"/></td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Name:"></asp:Label><asp:Label ID="ProductName" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="MessageLabel" runat="server" Text="MessageLabel"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
