using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResetPasswordPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void resetPasswordButton_Click(object sender, EventArgs e)
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aspwebsite3;";

        string emailAdd = emailTb.Text;
        string newPw = resetPasswordTb.Text;

        string query = "UPDATE clients " +
                        "SET Password = '" + newPw
                        + "' WHERE email = '" + emailAdd + "';";
        // Which could be translated manually to :
        // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'John', 'Doe', 'John Doe Villa')

        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;

        try
        {
            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            databaseConnection.Close();
            //MessageBox.Show("Appointment successfully updated.");

        }
        catch (Exception ex)
        {
            // Show any error message.
            //MessageBox.Show(ex.Message);
        }
    }
}