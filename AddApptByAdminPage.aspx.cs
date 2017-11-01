using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddApptByAdminPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginButton_Click(object sender, EventArgs e)
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aspwebsite3;";
        string query = "INSERT INTO appointments(`apptId`, `Email`, `Date`, `MissionId`, `DurationId`) VALUES (NULL, '" + emailTb.Text + "', '" + dateLab.Text + "', '" + missionList.SelectedValue + "', '" + durationList.SelectedValue + "')";
        // Which could be translated manually to :
        // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'John', 'Doe', 'John Doe Villa')

        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;

        try
        {
            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            //MessageBox.Show("Patient succesfully registered");

            databaseConnection.Close();
        }
        catch (Exception ex)
        {
            // Show any error message.
            //MessageBox.Show(ex.Message);
        }

        Response.Redirect("ManageAppts.aspx");
    }
}