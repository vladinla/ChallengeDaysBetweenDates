using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDays
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resultButton_Click(object sender, EventArgs e)
        {
            int date1 = Calendar1.SelectedDate.DayOfYear;

            int date2 = Calendar2.SelectedDate.DayOfYear;

            if (date1 > date2)
                resultLabel.Text = (date1 - date2).ToString();
            else
                resultLabel.Text = (date2 - date1).ToString();       
        }

        /*
        <<<ALTERNATIVE CODE>>>
           if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                resultLabel.Text = Calendar1.SelectedDate
                    .Subtract(Calendar2.SelectedDate)
                    .TotalDays.ToString();
            }
            else
            {
                resultLabel.Text = Calendar2.SelectedDate
                    .Subtract(Calendar1.SelectedDate)
                    .TotalDays.ToString();
            }
        */
    }
}