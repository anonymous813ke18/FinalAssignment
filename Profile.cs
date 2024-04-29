using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalAssignment
{
    public partial class Profile : Form
    {
        //Declaring and Initializing the connection string
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;";
        
        //Declaring a global variable
        String username;

        //Constructors
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(String username)
        {
            InitializeComponent();
            this.username = username;

            //Creating a connection to the database
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                //Declaring and Initializing the query
                String query = "SELECT * FROM UserInformation WHERE Username = @username";

                //Opening the connection to the database
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                OleDbDataReader reader = command.ExecuteReader();

                //Checking if the query generated an output
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Initializing the components used on the form
                        labelFname.Text = reader["First_Name"].ToString();
                        labelLname.Text = reader["Last_Name"].ToString();
                        labelEaddress.Text = reader["Email_Address"].ToString();
                        labelPnum.Text = reader["Phone_Number"].ToString();
                        labelUserName.Text = reader["Username"].ToString();
                        labelGender.Text = reader["Gender"].ToString();
                        labelHeight.Text = reader["Height"].ToString();
                        labelWeight.Text = reader["Weight"].ToString();
                    }
                }

                //Closing the connection to the database
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelFname_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating a connection to the database
                OleDbConnection connection = new OleDbConnection(connectionString);

                //Opening the connection to the database
                connection.Open();

                //Declaring and Initializing the query
                String query = "UPDATE UserInformation SET Calorie_Goal = " + int.Parse(textBox1.Text) + " WHERE Username = '" + username + "'";

                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Calorie Goal Set.");

                //Closing the connection to the database
                connection.Close();
            } catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        //Method to return to the HomePage.cs class
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(username);
            homePage.ShowDialog();
            this.Hide();
        }
    }
}
