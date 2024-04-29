using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FinalAssignment
{
    class HistoryFunctions
    {
        //Declaring and Initializing the Connection String
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;";

        //Method to check the History table for an existing record
        public bool checkHistory(String username, String date)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "SELECT * FROM History WHERE Username = '"+username+"' AND Date = '"+date+"'";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);

                //Opening the connection to the database
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);

                int rowCount = 0;
                object result = command.ExecuteScalar();

                //Checking if the row exists
                if (result != null)
                {
                    try
                    {
                        rowCount = Convert.ToInt32(result);
                    }
                    catch (FormatException ex) { rowCount = 1; }
                }

                if (rowCount > 0)
                {
                    //If the row exists return true
                    return true;
                }

                //Closing the connection to the database
                connection.Close();

                //If the row doesn't exists return false
                return false;
            }
            catch (Exception ex) { return false; }
        }

        //Method to Insert a new record in the History table
        public float insertHistory(String username, String date, float calories_burned) 
        {
            try
            {
                //Declaring and Initializing the query
                String query = "INSERT INTO History([Username], [Date], [Total_Calories]) VALUES('" + username + "','" + date + "'," + calories_burned + ")";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the database
                connection.Close();

                //Returning the calories burned
                return calories_burned;
            }
            catch (Exception ex) { return 1; }
        }

        //Method to update an existing record in the History table
        public float updateHistory(String username, String date, float calories_burnt)
        {
            float total_calories = 0;

            try
            {
                //Declaring and Initializing the query
                String query = "SELECT [Total_Calories] FROM History WHERE Username = '" + username + "' AND Date = '" + date + "'";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);

                //Opening the connection to the database
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);

                object result = command.ExecuteScalar();

                //Checking if the query generated an output
                if (result != null)
                {
                    total_calories = float.Parse(result.ToString()) + calories_burnt;
                }

                //Closing the connection to the database
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error occured in the block calculating the total calories:\n"+ex.Message); }

            try
            {
                //Declaring and Initializing the query
                String query = "UPDATE History SET [Total_Calories] = "+total_calories+" WHERE Username = '"+username+"' AND Date = '"+date+"'";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the database
                connection.Close();

                //Returning the total calories burned
                return total_calories;
            }
            catch (Exception ex) { return 1; }
        }
    }
}
