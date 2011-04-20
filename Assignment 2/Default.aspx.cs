using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;

/// @author Michael Willams
/// Assignment 2
/// Main class for loading data from the database and loading it
/// into the view state
public partial class _Default : System.Web.UI.Page
{
    public List<InvoiceLineItem> invoiceLineItems;

    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        // Only load the date if its a postback
        if (this.IsPostBack == false)
        {
            this.invoiceLineItems = new List<InvoiceLineItem>();

            cn = new OleDbConnection();

            string host = Request.Url.Host;

            if (host == "localhost")
            {
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Request.PhysicalApplicationPath + "\\assignment2.mdb";
            }
            else
            {
                cn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\hosting\chrispeters\williams\assignment2\assignment2.mdb";
            }
            
            cn.Open();

            cmd = new OleDbCommand("SELECT * FROM Invoice_Line_Item AS il" +
                " LEFT JOIN Customers AS c" +
                    " ON il.customer_id = c.id", cn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Customer customer = new Customer(int.Parse(dr["customer_id"].ToString()), dr["cus_name"].ToString(), dr["street"].ToString(),
                    dr["city"].ToString(), dr["state"].ToString(), dr["zip"].ToString());

                this.invoiceLineItems.Add(new InvoiceLineItem(int.Parse(dr["il.id"].ToString()), customer, int.Parse(dr["order_id"].ToString()),
                    dr["item_sku"].ToString(), dr["item_desc"].ToString(), int.Parse(dr["qty"].ToString()), Double.Parse(dr["unit_price"].ToString()), Double.Parse(dr["unit_weight"].ToString())));

            }

            // Store in view state
            ViewState["invoiceLineItems"] = this.invoiceLineItems;

            dr.Close();
            cn.Close();
        }
        else
        {
            // Check if we came from the crossPage.aspx
            if (Request.QueryString["err"] != null)
            {
                // We tried to view CrossPage without first visiting Default.aspx
                err.Text = "Please click view results before trying to view CrossPage.aspx<br/ /><br />";
                err.Style["color"] = "red";
                mainTxt.Visible = false;
            }

            // Set invoice line items now from the view state
            this.invoiceLineItems = (List<InvoiceLineItem>) ViewState["invoiceLineItems"];
        }
    }
}