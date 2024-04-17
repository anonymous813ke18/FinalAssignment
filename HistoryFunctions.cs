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
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;";

        public bool checkHistory(String username, String date)
        {
            try
            {
                String query = "SELECT * FROM History WHERE Username = '"+username+"' AND Date = '"+date+"'";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);

                int rowCount = 0;
                object result = command.ExecuteScalar();
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
                    return true;
                }
                connection.Close();
                return false;
            }
            catch (Exception ex) { return false; }
        }

        public float insertHistory(String username, String date, float calories_burned) 
        {
            try
            {
                String query = "INSERT INTO History([Username], [Date], [Total_Calories]) VALUES('" + username + "','" + date + "'," + calories_burned + ")";
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return calories_burned;
            }
            catch (Exception ex) { return 1; }
        }

        public float updateHistory(String username, String date, float calories_burnt)
        {
            float total_calories = 0;

            try
            {
                String query = "SELECT [Total_Calories] FROM History WHERE Username = '" + username + "' AND Date = '" + date + "'";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    total_calories = float.Parse(result.ToString()) + calories_burnt;
                }

                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error occured in the block calculating the total calories:\n"+ex.Message); }

            try
            {
                String query = "UPDATE History SET [Total_Calories] = "+total_calories+" WHERE Username = '"+username+"' AND Date = '"+date+"'";
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return total_calories;
            }
            catch (Exception ex) { return 1; }
        }
    }
}
