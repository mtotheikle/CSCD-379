<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab 4 Validation (Michael Williams)</title>
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
        <asp:ValidationSummary id="Errors" runat="server" ShowMessageBox="False" HeaderText=" Summary of Errors:" />
        <br /><br />
        <span style="float: left;">Enter a number between 1 and 10:*</span>
        <asp:TextBox ID="txtNumber" runat="server" CssClass="fl"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server"
            ControlToValidate="txtNumber"
            Display="Static"
            ErrorMessage="* This is a required field" Font-Bold="True">*</asp:RequiredFieldValidator>
        <asp:RangeValidator id="RangeValidator" runat="server"
            ErrorMessage="** The number is not in the range"
            ControlToValidate="txtNumber"
            MaximumValue="10" MinimumValue="1"
            ForeColor="Red"
            Display="Dynamic"
            Type="Integer" Font-Bold="True" CssClass="fl">**</asp:RangeValidator>
        <br /><br />

        My Custom Validator. <br />
        Do you like teaching? (y or n or yes or no):
        <asp:TextBox ID="txtTeaching" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator" runat="server"
            Font-Bold="true"
            ErrorMessage="*** You must choose from the following (Y,N,Yes,No). Not case sensitive."
            ValidateEmptyText="True"
            OnServerValidate="vaildateTeaching_ServerValidate"
            ControlToValidate="txtTeaching">***</asp:CustomValidator>

        <asp:Button ID="cmdOk" runat="server" Text="Ok" OnClick="cmdOK_Click" />
        <br /><br />
        <asp:Label ID="lblMessage" runat="server" EnableViewState="false" />
    </div>
    </form>
</body>
</html>
    