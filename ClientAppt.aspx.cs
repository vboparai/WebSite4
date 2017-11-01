using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;


public partial class ClientAppt : System.Web.UI.Page
{
    string newEmail;
    protected void Page_Load(object sender, EventArgs e)
    {


        newEmail = Request.QueryString["Email"].ToString();

        if (!this.IsPostBack)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["abcconnection"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            MySqlCommand comm = new MySqlCommand("select Appointments.ApptId, Appointments.Email, Appointments.Date, Clients.FirstName, Clients.Phone, Duration.Length as LengthInHours, Missions.Name as MissionType " +
                "from Appointments inner join Clients inner join duration inner join missions " +
                "on appointments.Email=Clients.email AND appointments.DurationId=Duration.DurationId AND appointments.MissionId=Missions.MissionId " +
                "WHERE appointments.Email = '" + newEmail + "';");
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                comm.Connection = sqlconn;
                da.SelectCommand = comm;
                DataTable dt = new DataTable();
                {
                    da.Fill(dt);
                    Gdview.DataSource = dt;
                    Gdview.DataBind();

                }

            }
        }
    }

    

    protected void addButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddApptPage.aspx?email=" + newEmail);
    }
}