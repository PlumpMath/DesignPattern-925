<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebAppTest._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    <div>
        <asp:Label Text="折扣：" runat="server" />
        <asp:TextBox ID="tbDiscount" runat="server" />
        <asp:Button ID="btnDiscount" runat="server" Text="打折" OnClick="OnDiscountClick" />
    </div>
    <div>
        <asp:Label Text="返现条件：" runat="server" />
        <asp:TextBox ID="tbReturnCondition" runat="server" />
        <asp:Label Text="返现金额：" runat="server" />
        <asp:TextBox ID="tbReturn" runat="server" />
        <asp:Button ID="btnReturn" runat="server" Text="返现" OnClick="OnReturnClick" />
    </div>
    <div>
        <asp:Label Text="返点条件：" runat="server" />
        <asp:TextBox ID="tbPointCondition" runat="server" />
        <asp:Label Text="返点率：" runat="server" />
        <asp:TextBox ID="tbPoint" runat="server" />
        <asp:Button ID="btnPoint" runat="server" Text="返点" OnClick="OnPointClick" />
    </div>
    <asp:Repeater ID="rpt" runat="server">
        <HeaderTemplate>
            <table>
                <tr>
                    <td>ProductId</td>
                    <td>ProductName</td>                            
                    <td>BrandName</td>                            
                    <td>Price</td>                            
                    <td>Discount</td>                            
                    <td>SellingPrice</td>
                    <td>Point</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("ProductId")%></td>
                <td><%#Eval("ProductName")%></td>                      
                <td><%#Eval("BrandName")%></td>
                <td><%#Eval("Price")%></td>
                <td><%#Eval("Discount")%></td>
                <td><%#Eval("SellingPrice")%></td>
                <td><%#Eval("Point")%></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
</asp:Content>
