using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Michael Williams
/// Lab 4
/// </summary>
public partial class Part2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnSubmit_OnClick(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            int number = Int32.Parse(txtNumber.Text);
            int sum = 0;

            // http://stackoverflow.com/questions/478968/sum-of-digits-in-c/478974#478974
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            int lastDigit = Int32.Parse(sum.ToString().Substring(sum.ToString().Length - 1));

            if (lastDigit == 0)
            {
                lblResult.Text = "<span style=\"font-weight: bold; color: green\">Success! The last digit of the checksum number is 0</span>";
            }
            else
            {
                lblResult.Text = "<span style=\"font-weight: bold; color: red\">Failure! The last digit of the checksum number is <b>not</b> 0</span>";
            }
        }
    }
}