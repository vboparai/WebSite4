using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManageAppts : System.Web.UI.Page
{
    //string newEmail;
    protected void Page_Load(object sender, EventArgs e)
    {
        //newEmail = Request.QueryString["Email"].ToString();


        if (!this.IsPostBack)
        {
            this.BindGrid();
        }
    }


    private void BindGrid()
    {
        string mainconn = ConfigurationManager.ConnectionStrings["abcconnection"].ConnectionString;
        MySqlConnection sqlconn = new MySqlConnection(mainconn);
        MySqlCommand comm = new MySqlCommand("select Appointments.ApptId, Appointments.Email, Appointments.Date, Clients.FirstName,Clients.LastName, Clients.Phone, Duration.Length as LengthInHours, Missions.Name as MissionType, appointments.LastUpdate " +
            "from Appointments inner join Clients inner join duration inner join missions " +
            "on appointments.Email=Clients.email AND appointments.DurationId=Duration.DurationId AND appointments.MissionId=Missions.MissionId " +
            ";");
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



    protected void addButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddApptByAdminPage.aspx");
    }


    protected void OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        Gdview.EditIndex = e.NewEditIndex;
        this.BindGrid();
    }


    protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = Gdview.Rows[e.RowIndex];
        int apptId = Convert.ToInt32(Gdview.DataKeys[e.RowIndex].Values[0]);
        string date = (row.Cells[3].Controls[0] as TextBox).Text;
        string mainconn = ConfigurationManager.ConnectionStrings["abcconnection"].ConnectionString;
        using (MySqlConnection con = new MySqlConnection(mainconn))
        {
            using (MySqlCommand cmd = new MySqlCommand("UPDATE Appointments SET Date = @Date  WHERE ApptId = @apptId"))
            {
                cmd.Parameters.AddWithValue("@ApptId", apptId);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        Gdview.EditIndex = -1;
        this.BindGrid();
    }


    protected void OnRowCancelingEdit(object sender, EventArgs e)
    {
        Gdview.EditIndex = -1;
        this.BindGrid();
    }


    protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int apptId = Convert.ToInt32(Gdview.DataKeys[e.RowIndex].Values[0]);
        string mainconn = ConfigurationManager.ConnectionStrings["abcconnection"].ConnectionString;
        using (MySqlConnection con = new MySqlConnection(mainconn))
        {
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Appointments WHERE apptId = @ApptId"))
            {
                cmd.Parameters.AddWithValue("@ApptId", apptId);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        this.BindGrid();
    }


    protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != Gdview.EditIndex)
        {
            (e.Row.Cells[0].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        }
    }





}