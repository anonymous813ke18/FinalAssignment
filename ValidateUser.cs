using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows;

namespace FinalAssignment
{
    class ValidateUser
    {
        //Declaring and Initializing the Connection String
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;";

        //Method to Validate that a user exists
        public bool validateUser(String username, String password)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "SELECT * FROM UserInformation WHERE Username = @username";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);

                //Opening tje connection to the database
                connection.Open();

                OleDbCommand command = new OleDbCommand(query,connection);
                command.Parameters.AddWithValue("@username", username);

                OleDbDataReader reader = command.ExecuteReader();

                //Checking if the query has generated and output
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (password == reader["Password"].ToString())
                        {
                            return true;
                        }
                    }
                }

                //Closing the connection to the database
                connection.Close();
                return false;
            }
            catch (Exception ex) { return false; }
        }

        //Method to validate the answer to the security question
        public bool validateAnswer(String answer, String username)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "SELECT * FROM UserInformation WHERE Username = @username";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);

                //Opening tje connection to the database
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                OleDbDataReader reader = command.ExecuteReader();

                //Checking if the query has generated and output
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (answer == reader["Answer"].ToString())
                        {
                            return true;
                        }
                    }
                }

                //Closing the connection to the database
                connection.Close();
                return false;
            }
            catch (Exception ex) { return false; }
        }
    }
}
