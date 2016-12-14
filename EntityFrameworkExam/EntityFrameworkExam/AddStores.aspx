<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStores.aspx.cs" Inherits="EntityFrameworkExam.AddStores" %>

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
            <asp:Label ID="lblStoreLocation" runat="server" Text="Store Location:"></asp:Label><asp:TextBox ID="txtStoreLocation" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblStoreTel" runat="server" Text="Store Phone:"></asp:Label><asp:TextBox ID="txtStoreTel" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPreferredStore" runat="server" Text="Preferred Store:"></asp:Label><asp:CheckBox ID="chkPreferred" runat="server" /><br />
            <asp:Button ID="btAddStore" runat="server" Text="Add Store" UseSubmitBehavior="true" OnClick="btAddStore_Click" />
        </div>
    </form>
</body>
</html>
