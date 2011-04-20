using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QueryStringRecipient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblInfo.Text = "<b>Item:</b> " + Request.QueryString["Item"];
        lblInfo.Text += "<br /><b>Show Full Record:</b> ";
        lblInfo.Text += Request.QueryString["Mode"];
    }

    protected void getTrace_Click(object sender, EventArgs e)
    {
        Trace.IsEnabled = true;
    }
}