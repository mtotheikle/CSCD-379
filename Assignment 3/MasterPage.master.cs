using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class MasterPage : System.Web.UI.MasterPage
{
    private OleDbConnection cn;
    private OleDbDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    public OleDbConnection getConnection()
    {
        if (this.cn == null)
        {
            this.cn = new OleDbConnection();

            string host = Request.Url.Host;

            if (host == "localhost")
            {
                this.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Request.PhysicalApplicationPath + "\\mwilliams_assignment3.mdb";
            }
            else
            {
                // @todo
                this.cn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\hosting\chrispeters\williams\assignment2\assignment2.mdb";
            }

            this.cn.Open();
        }

        return this.cn;
    }
}
