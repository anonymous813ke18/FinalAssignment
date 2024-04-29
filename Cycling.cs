using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
    public partial class Cycling : Form
    {
        //Declaring and Initializing the global varibles
        String username;
        float result = 0;

        //Constructors
        public Cycling()
        {
            InitializeComponent();
        }

        public Cycling(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        //Declaring and Initializing the objects for classes used in the program
        CalculateGoal obj = new CalculateGoal();
        CalculateMET obj1 = new CalculateMET();
        InsertOperations obj2 = new InsertOperations();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Method to calculate the calories burned and insert a new record in the Cycling table
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Declaring and Initializing variables used in the method
            bool inputResult = false;
            String workoutIntensity = IntensityComboBox.Text, date = dateTimePicker.Text; 
            float MET = obj1.getMET("Cycling", workoutIntensity), time = float.Parse(textTIme.Text), speed = float.Parse(textSpeed.Text), distance = float.Parse(textDistance.Text);
            
            //Calculating the calories burned
            result = obj.calculateCaloriesBurned(username, time, MET);

            //Inserting into the Cycling table
            inputResult = obj2.insertIntoCycling(username, time, distance, speed, MET, date, result);

            //Checking if the session was recorded successfully
            if (inputResult == true)
            {
                MessageBox.Show("Workout session has been recorded.\nCalories Burned are: " + result);
            } 
            else
            {
                MessageBox.Show("There was an error in recording the workout session.");
            }
        }

        //Method to return to the HomePage.cs class
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage obj3 = new HomePage(result, username, dateTimePicker.Text);
            obj3.ShowDialog();
            this.Hide();
        }
    }
}
