﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalAssignment
{
    public partial class JumpRope : Form
    {
        //Declaring and Initializing the global varibles
        String username;
        float result = 0;

        //Constructors
        public JumpRope()
        {
            InitializeComponent();
        }

        public JumpRope(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        //Declaring and Initializing the objects for classes used in the program
        CalculateGoal obj = new CalculateGoal();
        CalculateMET obj1 = new CalculateMET();
        InsertOperations obj2 = new InsertOperations();

        //Method to calculate the calories burned and insert a new record in the JumpRope table
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Declaring and Initializing variables used in the method
            bool inputResult = false;
            String date = dateTimePicker.Text;
            float MET = obj1.getMET("Jump Rope", ""), time = float.Parse(textTIme.Text);

            //Calculating the calories burned
            result = obj.calculateCaloriesBurned(username, time, MET);

            //Inserting into the JumpRope table
            inputResult = obj2.insertIntoJumpRope(username, time, MET, date, result);

            //Checking if the session was recorded successfully
            if (inputResult)
            {
                MessageBox.Show("Workout session has been recorded.\nCalories Burned are: " + result);
            }
            else
            {
                MessageBox.Show("There was an error in recording the data.");
            }
        }

        //Method to return to the HomePage.cs class
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage obj3 = new HomePage(result, username, dateTimePicker.Text);
            obj3.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
