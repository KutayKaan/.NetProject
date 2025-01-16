<%@ Page Title="" Language="C#" MasterPageFile="~/homePage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GameMarkt.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="219px" TextMode="Email"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="40px" Width="219px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="48px" OnClick="Button1_Click" Text="Sign Up" Width="228px" />
    </form>
</asp:Content>
