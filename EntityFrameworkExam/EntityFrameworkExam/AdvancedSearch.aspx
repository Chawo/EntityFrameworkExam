<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvancedSearch.aspx.cs" Inherits="EntityFrameworkExam.AdvancedSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="links">
        <a runat="server" href="~/Default.aspx">Back to Home</a><br />
    </div>
     <div id="AuthorSearch">
        <asp:Label Text="Search Author " runat="server"></asp:Label><asp:TextBox ID="txtAuthorSearchText" runat="server"></asp:TextBox>
        <asp:Button ID="btnAuthorSearch" runat="server" OnClick="btnAuthorSearch_Click" UseSubmitBehavior="true" Text="Search" />
        <br />
         <asp:Label Text="Search Title " runat="server"></asp:Label><asp:TextBox ID="txtTitleSearchText" runat="server"></asp:TextBox>
        <asp:Button ID="btnTitleSearch" runat="server" OnClick="btnTitleSearch_Click" UseSubmitBehavior="true" Text="Search" />
        <br />
         <asp:GridView ID="authorsResultGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        <br />
        <asp:GridView ID="titlesResultGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
    </div>
    </div>
    </form>
</body>
</html>
