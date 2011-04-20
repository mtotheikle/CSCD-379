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
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void cmdOK_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
        {
            lblMessage.Text = "Form invalid!";
        }
        else
        {
            lblMessage.Text = "<span style=\"color: green; font-weight: bold;\">cmdOK_Click event handler executed and form is valid!</span>";
        }
    }

    protected void vaildateTeaching_ServerValidate(object source, ServerValidateEventArgs e)
    {
        string answer = (txtTeaching.Text).ToLower();

        if (answer == "yes" || answer == "no" || answer == "y" || answer == "n")
        {
            e.IsValid = true;
            return;
        }

        e.IsValid = false;
    }
}