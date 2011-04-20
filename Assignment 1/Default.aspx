<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Michael's Awesome Age Calculator</title>
</head>
<body>
    <img src="banner.jpg" />
    <br />
    <label id="date" runat="server"></label>
    <p>How old will you be when you graduate?</p>
    
    <form id="datesForm" runat="server" onload="DatesForm_Load">
        <fieldset style="border: none; margin: 0 auto;">
            <dl>
                <dt><label>Enter your birthdate</label></dt>
            </dl>
	        <dl>
		        <dt><label style="width: 100px; display: block; float: left;">Month:</label><input id="BirthdayMonthInput" runat="server" style="margin-top: 0px" /></dt>
            </dl>
	        <dl>
		        <dt><label style="width: 100px; display: block; float: left;" for="username">Day:</label><input id="BirthdayDayInput" runat="server" style="margin-top: 0px" /></dt>
            </dl>
            <dl>
		        <dt><label style="width: 100px; display: block; float: left;" for="username">Year:</label><input id="BirthdayYearInput" runat="server" style="margin-top: 0px" /></dt>
            </dl>
            <dl>
                <dt><label>Enter The date you will graduate</label></dt>
            </dl>
	        <dl>
		        <dt><label style="width: 100px; display: block; float: left;">Month:</label><input id="GradMonthInput" runat="server" style="margin-top: 0px" /></dt>
            </dl>
	        <dl>
		        <dt><label style="width: 100px; display: block; float: left;" for="username">Day:</label><input id="GradDayInput" runat="server" style="margin-top: 0px" /></dt>
            </dl>
            <dl>
		        <dt><label style="width: 100px; display: block; float: left;" for="username">Year:</label><input id="GradYearInput" runat="server" style="margin-top: 0px" /></dt>
            </dl>
            <dl>
                <dt>Calculate your age at graduation:<asp:Button ID="submitBtn" runat="server" Text="Get Age" OnClick="CalcAge" /></dt>
            </dl>
        </fieldset>
        <p style="font-weight: bold" ID="Result" runat="server"></p></dt>      
    </form>
</body>
</html>
