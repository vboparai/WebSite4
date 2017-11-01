using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginButton_Click(object sender, EventArgs e)
    {
        string email = usernameTb.Text;
        string pw = passwordTb.Text;

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aspwebsite3;";
        // Select all
        string query = "SELECT * FROM users where email='" + email + "' AND Password='" + pw + "';";


        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;
        MySqlDataReader reader;

        try
        {
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            // Success, now list 

            // If there are available rows
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //ID                              First name                  Last Name                    Address
                    Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                    // Example to save in the listView1 :
                    //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                    //var listViewItem = new ListViewItem(row);
                    //listView1.Items.Add(listViewItem);

                }
                // Response.Redirect("WelcomePage.aspx?Email=" + email);
                Response.Redirect("ManageAppts.aspx?Email=" + email);
            }
            else
            {


                loginLabel.Text = "Login: Incorrect Username/Password!";


                Console.WriteLine("No rows found.");
            }

            databaseConnection.Close();
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
            // must use a jquery method/function
        }

    }
}