<%@ Page Title="" Language="C#" MasterPageFile="~/homePage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GameMarkt.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" Height="36px" TextMode="Email" Width="205px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="36px" TextMode="Password" Width="205px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="31px" Text="Login" Width="221px" />
        <br />
    </form>
</asp:Content>
