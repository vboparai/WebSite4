using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WelcomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        welcomeLabel.Text = "Welcome " + Request.QueryString["Email"].ToString();
        dateLabel.Text = "The date and time is " + @DateTime.Now;
        

    }
}