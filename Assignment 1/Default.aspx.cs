using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
 * Main class for calculating users age. Very simple class.
 * 
 * CSCD 379 - Assignment 1
 * 4/6/2011
 * 
 * @author Michael Williams <michael.williams@funsational.com>
 */
public partial class _Default : System.Web.UI.Page 
{
    protected void DatesForm_Load(object sender, EventArgs e)
    {
        date.InnerText = "The current date is " + DateTime.Today.ToString("dddd, MMMM d, yyyy");
    }

    protected void CalcAge(object sender, EventArgs e)
    {
        DateTime BirthdayGradYear = new DateTime(int.Parse(GradYearInput.Value), int.Parse(BirthdayMonthInput.Value), int.Parse(BirthdayDayInput.Value));
        DateTime GradYear = new DateTime(int.Parse(GradYearInput.Value), int.Parse(GradMonthInput.Value), int.Parse(GradDayInput.Value));

        int years = int.Parse(GradYearInput.Value) - int.Parse(BirthdayYearInput.Value);

        // Check if birhtday has happened this year yet
        if (BirthdayGradYear > GradYear)
        {
           years--;
        }

        Result.InnerText = "You will be " + years + " years old when you graduate.";
    }
}