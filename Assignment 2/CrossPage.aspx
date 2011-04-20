<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CrossPage.aspx.cs" Inherits="CrossPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Invoice Line Items</title>
    <style type="text/css">
        td 
        {
            padding: 5px;
        }   
    </style>
</head>
<body>
    <div>
        Here are your results!<br />
        <asp:Table ID="tbl" runat="server"></asp:Table><br />
        <a href="Default.aspx">Go Back to Main Page</a>
    </div>
</body>
</html>
