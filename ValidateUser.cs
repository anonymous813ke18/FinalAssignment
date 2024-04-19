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
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;";

        public bool validateUser(String username, String password)
        {
            try
            {
                String query = "SELECT * FROM UserInformation WHERE Username = @username";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();

                OleDbCommand command = new OleDbCommand(query,connection);
                command.Parameters.AddWithValue("@username", username);

                OleDbDataReader reader = command.ExecuteReader();
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
                connection.Close();
                return false;
            }
            catch (Exception ex) { return false; }
        }

        public bool validateAnswer(String answer, String username)
        {
            try
            {
                String query = "SELECT * FROM UserInformation WHERE Username = @username";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                OleDbDataReader reader = command.ExecuteReader();
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
                connection.Close();
                return false;
            }
            catch (Exception ex) { return false; }
        }
    }
}
