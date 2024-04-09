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
        //public CalculateGoal(float goalAchieved, float totalGoal, float goalPercent)
        //{
        //    this.totalGoal = totalGoal;
        //    this.goalPercent = goalPercent;
        //    this.goalAchieved = goalAchieved;
        //}

        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment.mdb;";

        public float calculateGoalPercent(float goalAchieved, float totalGoal)
        {
            float goalPercent = (goalAchieved * 100) / totalGoal; return goalPercent;
        }

        public float getGoal(String username)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                String query = "SELECT * FROM UserInformation WHERE Username = '"+username+"'";

                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return float.Parse(reader["Calorie_Goal"].ToString());
                    }
                }
                connection.Close();
                return 0;
            }
            catch (Exception e) {  return 0; }
        }

        public bool setGoal(String username, float goal) 
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                String query = "INSERT INTO UserInformation([Calorie_Goal]) VALUES(" + goal + ")";
                OleDbCommand command = new OleDbCommand(query,connection);
                command.ExecuteNonQuery();
                return true;
            }catch (Exception e) { return false; }
        }

        public float calculateCaloriesBurned(String username, float time, float MET)
        {
            float weight = 0;
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                String query = "SELECT * FROM UserInformation WHERE Username = @username";

                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        weight = float.Parse(reader["Weight"].ToString());
                    }
                }
                connection.Close();
            }
            catch (Exception e) { return 0; }

            return (MET * weight * time);
        }
    }
}
