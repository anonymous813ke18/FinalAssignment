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
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;";
        String username;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(String username)
        {
            InitializeComponent();
            this.username = username;

            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                String query = "SELECT * FROM UserInformation WHERE Username = @username";
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
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
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                String query = "UPDATE UserInformation SET Calorie_Goal = " + int.Parse(textBox1.Text) + " WHERE Username = '" + username + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Calorie Goal Set.");
                connection.Close();
            } catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(username);
            homePage.ShowDialog();
            this.Hide();
        }
    }
}
