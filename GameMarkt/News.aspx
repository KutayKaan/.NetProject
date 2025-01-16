<%@ Page Title="Game News" Language="C#" MasterPageFile="~/homePage.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="GameMarkt.News" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div style="text-align: center; padding: 20px; background-color: #f4f4f4; border-radius: 8px;">
            <h2>Game News</h2>
            <div id="newsContainer" runat="server">
                <!-- Burada haberler görüntülenecek -->
            </div>
        </div>
    </form>
</asp:Content>
