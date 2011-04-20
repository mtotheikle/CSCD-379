<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Welcome!<br /><br />

        <asp:Label ID="err" runat="server" Text=""></asp:Label>

        <p runat="server" id="mainTxt">Results have been loaded. Click "View Results" to view via a Cross-Page Postback!<br /><br /></p>

        <asp:Button runat="server" ID="cmdPost" PostBackUrl="CrossPage.aspx" Text="View Results" />
    </div>
    </form>
</body>
</html>
