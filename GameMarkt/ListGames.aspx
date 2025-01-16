<%@ Page Title="" Language="C#" MasterPageFile="~/homePage.Master" AutoEventWireup="true" CodeBehind="ListGames.aspx.cs" Inherits="GameMarkt.ListGames" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" CellPadding="20" CellSpacing="20" BorderWidth="0" style="width: 80%; margin: 0 auto;">
            <ItemTemplate>
                <table style="width: 100%; border: 1px solid #ccc; padding: 20px; text-align: center; background-color: #f9f9f9;">
                    <tr>
                        <td>
                            <asp:Image ID="Image1" runat="server" Height="250px" ImageUrl='<%# Eval("GamePhoto") %>' Width="250px" style="max-width: 100%; height: auto;" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Producer Name:</strong>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("ProducerName") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Game Name:</strong>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("GameName") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Game Year:</strong>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("GameYear") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Metacritic Score:</strong>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("MetacriticScore") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Game Price:</strong>
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("GamePrice", "{0} $") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Game Confirmation:</strong>
                            <asp:Label ID="Label8" runat="server" Text='<%# Eval("GameConfirmation") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Game Description:</strong>
                            <asp:TextBox ID="TextBox1" runat="server" Height="40px" Text='<%# Eval("GameDescription") %>' Width="220px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>

