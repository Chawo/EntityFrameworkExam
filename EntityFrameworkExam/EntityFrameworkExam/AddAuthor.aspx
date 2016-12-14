<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAuthor.aspx.cs" Inherits="EntityFrameworkExam.AddAuthor" %>

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
    <asp:Label ID="lblFirstName" runat="server" Text="FirstName:"></asp:Label><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblLastName" runat="server" Text="LastName:"></asp:Label><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblCoutryOfResidence" runat="server" Text="Country of residence:"></asp:Label><asp:TextBox ID="txtCountryOfResidence" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnAddAuthor" runat="server" Text="Add Author" OnClick="btnAddAuthor_Click"  UseSubmitBehavior="true"/>
    
    </div>
    </form>
</body>
</html>
