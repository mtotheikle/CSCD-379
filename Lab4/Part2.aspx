<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Part2.aspx.cs" Inherits="Part2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Michael Williams Lab 4 (Part 2)</title>
    <style type="text/css">
        .fl 
        {
            float: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span style="float: left;">Enter a number whose sums last digit equals 0:</span>
        <span style="float: left;"><asp:TextBox ID="txtNumber" runat="server"></asp:TextBox></span>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server"
            ControlToValidate="txtNumber"
            Display="Static"
            ErrorMessage="* This is a required field"  CssClass="fl" Font-Bold="True"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator"
            runat="server"
            ErrorMessage="** Please enter number greater than 0 and less than 100,000,000"
            MinimumValue="1" MaximumValue="999999999"
            ControlToValidate="txtNumber"
            Type="Integer"
            CssClass="fl" Font-Bold="True" />
        <br /><br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_OnClick" />
    </div>
    </form>
</body>
</html>
