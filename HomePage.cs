using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
    public partial class HomePage : Form
    {
        //Declaring the global variables
        String username, date, total_caloriesS;
        float caloriesBurnt, total_calories;

        //Declaring and Initializing the objects of classes used in the program
        HistoryFunctions historyFunctions = new HistoryFunctions();
        CalculateGoal calorieGoal = new CalculateGoal();

        //Contructors
        public HomePage()
        {
            InitializeComponent();
        }
        //Construstor called after loggin in or registration
        public HomePage(String username)
        {
            InitializeComponent();
            this.username = username;

            //Setting the solid gauge value when logging in or after registration
            total_calories = calorieGoal.getFromHistory(username, DateTime.Now.ToString("dd MMMM yyyy"));
            solidGauge1.Value = calorieGoal.calculateGoalPercent(total_calories, calorieGoal.getGoal(username));
        }
        //Constructor called from the activity pages
        public HomePage(float caloriesBurnt, String username, String date)
        {
            InitializeComponent();
            this.caloriesBurnt = caloriesBurnt;
            this.username = username;
            this.date = date;

            //Checking the histroy to see if a record with the same username and date already exists
            bool checkHist = historyFunctions.checkHistory(this.username, this.date);

            if (checkHist)
            {
                //If the record already exists then update the Total Calories column
                total_calories = historyFunctions.updateHistory(this.username, this.date, this.caloriesBurnt);
            }
            else
            {
                //If the record doesn't exist insert a new one
                total_calories = historyFunctions.insertHistory(this.username, this.date, this.caloriesBurnt);
            }         
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            solidGauge1.Uses360Mode = true;
            solidGauge1.From = 0;
            solidGauge1.To = 100;

            float goalPercent, goal;
            goal = calorieGoal.getGoal(username);

            //Check if the user has set the goal or not
            if (goal == 0)
            {
                MessageBox.Show("To set a calorie goal go to Profile.");
            }
            else
            {
                //If the user has already set the goal, then calculate how much of it is completed and set the value for the solid gauge
                goalPercent = calorieGoal.calculateGoalPercent(total_calories, goal);
                solidGauge1.Value = goalPercent;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        //Method to call the Profile.cs class
        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(username);
            profile.ShowDialog();
            this.Hide();
        }

        //Method to call the LoginForm.cs class
        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Hide();
        }

        //Method to call the Walking.cs class
        private void labelWalking_Click(object sender, EventArgs e)
        {
            Walking walking = new Walking(username);
            walking.ShowDialog();
            this.Hide();
        }

        //Method to call the Running.cs class
        private void labelRunning_Click(object sender, EventArgs e)
        {
            Running running = new Running(username);
            running.ShowDialog();
            this.Hide();
        }

        //Method to call the Swimming.cs class
        private void labelSwimming_Click(object sender, EventArgs e)
        {
            Swimming swimming = new Swimming(username);
            swimming.ShowDialog();
            this.Hide();
        }

        //Method to call the Yoga.cs class
        private void labelYoga_Click(object sender, EventArgs e)
        {
            Yoga yoga = new Yoga(username);
            yoga.ShowDialog();
            this.Hide();
        }

        //Method to call the History.cs class
        private void button3_Click(object sender, EventArgs e)
        {
            History history = new History(username);
            history.ShowDialog();
            this.Hide();
        }

        //Method to call the Cycling.cs class
        private void labelCycling_Click(object sender, EventArgs e)
        {
            Cycling cycling = new Cycling(username);
            cycling.ShowDialog();
            this.Hide();
        }

        //Method to call the JumpRope.cs class
        private void labelJumpRope_Click(object sender, EventArgs e)
        {
            JumpRope jumpRope = new JumpRope(username);
            jumpRope.ShowDialog();
            this.Hide();
        }
    }
}
