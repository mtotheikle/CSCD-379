<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryStringSender.aspx.cs" Inherits="QueryStringSender" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl" runat="server" Text=""></asp:Label><br />
        <asp:ListBox ID="listBox" runat="server" Height="200"></asp:ListBox><br />
        <asp:CheckBox ID="chkDetails" runat="server" Text="Show Full Details" /><br />
        <asp:Button ID="cmdGo" runat="server" Text="View Information" OnClick="cmdGo_Click" />
    </div>
    </form>
</body>
</html>
