using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Media.Media3D;

namespace FinalAssignment
{
    class InsertOperations
    {
        //Declaring and Initializing a Connection String
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;"; 
        
        //Method to Insert into the UserInformation table
        public bool insertIntoUserInformation(String fname, String lname, float height, float weight, long pnumber, String email, String gender, String username, String password, String securityQ, String answers)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "INSERT INTO UserInformation([First_Name], [Last_Name], [Height], [Weight], [Phone_Number], [Email_Address], [Gender], [Username], [Password], [Security_Question], [Answer]) VALUES('"+fname+"','"+lname+"',"+height+","+weight+","+pnumber+",'"+email+"','"+gender+"','"+username+"','"+password+"','"+securityQ+"','"+answers+"')";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the databse
                connection.Close();

                return true;
            } catch (Exception ex) { return false; }
        }

        //Method to Insert into the Cycling table
        public bool insertIntoCycling(String username, float time, float distance, float speed, float MET, String date, float calories_burned)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "INSERT INTO Cycling([Username], [Time], [Distance], [Speed], [MET], [Date], [Calories_Burned]) VALUES('" + username + "'," + time + "," + distance + "," + speed + "," + MET + ",'" + date + "'," + calories_burned + ")";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the databse
                connection.Close();

                return true;
            }
            catch (Exception ex) { return false; }
        }

        //Method to Insert into the Walking table
        public bool insertIntoWalking (String username, float time, float distance, float speed, float MET, String date, float calories_burned)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "INSERT INTO Walking([Username], [Time], [Distance], [Speed], [MET], [Date], [Calories_Burned]) VALUES('" + username + "'," + time + "," + distance + "," + speed + "," + MET + ",'" + date + "'," + calories_burned + ")";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the databse
                connection.Close();

                return true;
            }
            catch (Exception ex) { return false; }
        }

        //Method to Insert into the Running table
        public bool insertIntoRunning (String username, float time, float distance, float speed, float MET, String date, float calories_burned)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "INSERT INTO Running([Username], [Time], [Distance], [Speed], [MET], [Date], [Calories_Burned]) VALUES('" + username + "'," + time + "," + distance + "," + speed + "," + MET + ",'" + date + "'," + calories_burned + ")";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the databse
                connection.Close();

                return true;
            }
            catch (Exception ex) { return false; }
        }

        //Method to Insert into the Swimming table
        public bool insertIntoSwimming (String username, float time, float laps, float MET, String date, float calories_burned)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "INSERT INTO Swimming([Username], [Time], [Laps], [MET], [Date], [Calories_Burned]) VALUES('" + username + "'," + time + "," + laps + "," + MET + ",'" + date + "'," + calories_burned + ")";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the databse
                connection.Close();

                return true;
            }
            catch (Exception ex) { return false; }
        }

        //Method to Insert into the Yoga table
        public bool insertIntoYoga(String username, float time, float MET, String date, float calories_burned)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "INSERT INTO Yoga([Username], [Time], [MET], [Date], [Calories_Burned]) VALUES('" + username + "'," + time + "," + MET + ",'" + date + "'," + calories_burned + ")";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the databse
                connection.Close();

                return true;
            }
            catch (Exception ex) { return false; }
        }

        //Method to Insert into the JumpRope table
        public bool insertIntoJumpRope(String username, float time, float MET, String date,  float calories_burned)
        {
            try
            {
                //Declaring and Initializing the query
                String query = "INSERT INTO JumpRope([Username], [Time], [MET], [Date], [Calories_Burned]) VALUES('" + username + "'," + time + "," + MET + ",'" + date + "'," + calories_burned + ")";

                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(query, connection);

                //Opening the connection to the database
                connection.Open();
                command.ExecuteNonQuery();

                //Closing the connection to the databse
                connection.Close();

                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
