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
    public partial class Yoga : Form
    {
        String username;
        float result = 0;

        public Yoga()
        {
            InitializeComponent();
        }

        public Yoga(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        CalculateGoal obj = new CalculateGoal();
        CalculateMET obj1 = new CalculateMET();
        InsertOperations obj2 = new InsertOperations();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool inputResult = false;
            String workoutIntensity = IntensityComboBox.Text, date = dateTimePicker.Text;
            float MET = obj1.getMET("Swimming", workoutIntensity), time = float.Parse(textTIme.Text);
            result = obj.calculateCaloriesBurned(username, time, MET);

            inputResult = obj2.insertIntoYoga(username, time, MET, date, result);
            if (inputResult)
            {
                MessageBox.Show("Workout session has been recorded.\nCalories Burned are: " + result);
            }
            else
            {
                MessageBox.Show("There was an error in recording the workout session:\n" + inputResult);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage obj3 = new HomePage(result, username, dateTimePicker.Text);
            obj3.ShowDialog();
            this.Hide();
        }
    }
}
