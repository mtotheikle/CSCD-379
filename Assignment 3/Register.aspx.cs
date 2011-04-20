using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "New User Registration";

        MasterPage mp = Page.Master as MasterPage;

        OleDbConnection cn = mp.getConnection();

        OleDbCommand cmd = new OleDbCommand("SELECT * FROM customers AS c", cn);

        OleDbDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            lbl1.InnerText = dr["firstname"].ToString();
        }
    }
}