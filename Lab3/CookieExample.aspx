<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CookieExample.aspx.cs" Inherits="CookieExample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
        <br /><br />
        Enter Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="cmdStore" runat="server" Text="Create Cookie" OnClick="cmdStore_Click" />
    </div>
    </form>
</body>
</html>
