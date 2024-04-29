using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalAssignment
{
    class CalculateGoal
    {
        //Declaring and Initializing a Connection String
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;";

        //Method to calculate what percent of goal has been achieved by the user
        public float calculateGoalPercent(float goalAchieved, float totalGoal)
        {
            float goalPercent = (goalAchieved * 100) / totalGoal; 
            return goalPercent;
        }

        //Method to retrive the Calorie Goal of a particular user from the UserInformation table
        public float getGoal(String username)
        {
            try
            {
                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);

                //Declaring and Initializing the query
                String query = "SELECT * FROM UserInformation WHERE Username = '"+username+"'";

                //Opening the connection to the database
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();

                //Checking if the query returned an output
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return float.Parse(reader["Calorie_Goal"].ToString());
                    }
                }

                //Closing the connection to the database
                connection.Close();
                return 0;
            }
            catch (Exception e) {  return 0; }
        }

        //Method to set the Calorie Goal of a particular user
        public bool setGoal(String username, float goal) 
        {
            try
            {
                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);

                //Declaring and Initializing the query
                String query = "INSERT INTO UserInformation([Calorie_Goal]) VALUES(" + goal + ")";

                //Opening the connection to the database
                connection.Open();
                OleDbCommand command = new OleDbCommand(query,connection);
                command.ExecuteNonQuery();

                //Closing the connection to the database
                connection.Close();
                return true;
            }catch (Exception e) { return false; }
        }

        //Method to calculate the Calories Burned after performing an activity
        public float calculateCaloriesBurned(String username, float time, float MET)
        {
            float weight = 0;

            //Fetching the weight of the particular user from the UserInformation table
            try
            {
                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);

                //Declaring and Initializing the query
                String query = "SELECT * FROM UserInformation WHERE Username = @username";

                //Opening the connection to the database
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                OleDbDataReader reader = command.ExecuteReader();

                //Checking if the query returned an output
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        weight = float.Parse(reader["Weight"].ToString());
                    }
                }

                //Closing the connection to the database
                connection.Close();
            }
            catch (Exception e) { return 0; }

            //Calculating the Calories Burned and returning it
            return (MET * weight * time);
        }

        //Fetching the total calories burned by a user on a particular date from the history table
        public float getFromHistory(String username, String date) 
        {
            //Declaring and Initializing the query
            String query = "SELECT * FROM History WHERE Username = '" + username + "' AND Date = '" + date + "'";
            try
            {
                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                //Checking if the query returned an output
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return float.Parse(reader["Total_Calories"].ToString());
                    }
                }

                //Closing the connection to the database
                connection.Close();
                return 0;
            } catch (Exception e) { return 0; }
        }
    }
}
