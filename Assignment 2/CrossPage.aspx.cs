using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// @author Michael Willams
/// Assignment 2
/// Main class for displaying the invoice line items which are 
/// populated from the prev page
public partial class CrossPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get previous page
        _Default prevPage = PreviousPage as _Default;

        if (prevPage != null)
        {
            List<InvoiceLineItem> invoiceLineItems = (List<InvoiceLineItem>) prevPage.invoiceLineItems;

            if (invoiceLineItems == null)
            {
                Response.Redirect("Default.aspx?err=1");
            }

            // Create table with data
            TableRow row = new TableRow();
            row.BorderStyle = BorderStyle.Double;

            // Add table row for headings
            row.Cells.Add(addCell("Invoice Line Item Id"));
            row.Cells.Add(addCell("Order Id"));
            row.Cells.Add(addCell("Customer Information"));
            row.Cells.Add(addCell("Item Description"));
            row.Cells.Add(addCell("Item SKU"));
            row.Cells.Add(addCell("Unit Price"));
            row.Cells.Add(addCell("Qty"));
            row.Cells.Add(addCell("Sub Total"));
            row.Cells.Add(addCell("Shipping Cost"));
            row.Cells.Add(addCell("Total Cost"));

            tbl.Rows.Add(row);

            // Add each invoice line item to table
            foreach (InvoiceLineItem invoiceLineItem in invoiceLineItems)
            {
                row = new TableRow();

                row.Cells.Add(addCell(invoiceLineItem.Id.ToString()));
                row.Cells.Add(addCell(invoiceLineItem.OrderId.ToString()));
                row.Cells.Add(addCell(invoiceLineItem.Customer.ToString()));
                row.Cells.Add(addCell(invoiceLineItem.ItemDesc));
                row.Cells.Add(addCell(invoiceLineItem.ItemSku));
                row.Cells.Add(addCell("$" + invoiceLineItem.UnitPrice));
                row.Cells.Add(addCell(invoiceLineItem.Qty.ToString()));
                row.Cells.Add(addCell("$" + (invoiceLineItem.UnitPrice * invoiceLineItem.Qty)));
                row.Cells.Add(addCell("$" + invoiceLineItem.calcShippingCost()));
                row.Cells.Add(addCell("$" + (invoiceLineItem.calcShippingCost() + (invoiceLineItem.UnitPrice * invoiceLineItem.Qty))));

                tbl.Rows.Add(row);
            }
        }
        else
        {
            Response.Redirect("Default.aspx?err=1");
        }
    }

    /**
     * Create a new table cell
     * Idea from Chris on Blackboard
     */
    private TableCell addCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.Double;
        cell.BorderWidth = 3;
        cell.Text = pText;

        return cell;
    }
}