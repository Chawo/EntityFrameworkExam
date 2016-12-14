<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBooks.aspx.cs" Inherits="EntityFrameworkExam.ListBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="links">
        <a runat="server" href="~/Default.aspx">Back to Home</a><br />
    </div>
    <div>
    
        <asp:DropDownList ID="authorsDropDownList" runat="server" onselectedindexchanged="authorsDropDownList_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>

    </div>
        <asp:GridView ID="titlesGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>
