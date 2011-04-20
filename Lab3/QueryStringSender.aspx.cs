using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QueryStringSender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            listBox.Items.Add("Econo Sofa");
            listBox.Items.Add("Suprem Leather Drapery");
            listBox.Items.Add("Threadbare Carpet");
            listBox.Items.Add("Antique Lamp");
            listBox.Items.Add("Retro-Finish Jacuzzi");
       } 
    }

    protected void cmdGo_Click(Object sender, EventArgs e)
    {
        if (listBox.SelectedIndex == -1)
        {
            lbl.Text = "You must select an item.";
        }
        else
        {
            string url = "QueryStringRecipient.aspx?";
            url += "Item=" + Server.UrlEncode(listBox.SelectedItem.Text) + "&";
            url += "Mode=" + chkDetails.Checked.ToString();
            Response.Redirect(url);
        }
    }
}