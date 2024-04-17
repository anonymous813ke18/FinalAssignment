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
        String username, date, total_caloriesS;
        float caloriesBurnt, total_calories;

        HistoryFunctions historyFunctions = new HistoryFunctions();
        CalculateGoal calorieGoal = new CalculateGoal();

        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(String username)
        {
            InitializeComponent();
            this.username = username;
            total_calories = calorieGoal.getFromHistory(username, DateTime.Now.ToString("dd MMMM yyyy"));
            solidGauge1.Value = calorieGoal.calculateGoalPercent(total_calories, calorieGoal.getGoal(username));
        }

        public HomePage(float caloriesBurnt, String username, String date)
        {
            InitializeComponent();
            this.caloriesBurnt = caloriesBurnt;
            this.username = username;
            this.date = date;

            bool checkHist = historyFunctions.checkHistory(this.username, this.date);

            if (checkHist)
            {
                total_calories = historyFunctions.updateHistory(this.username, this.date, this.caloriesBurnt);
            }
            else
            {
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
            if (goal == 0)
            {
                MessageBox.Show("To set a calorie goal go to Profile.");
            }
            else
            {
                goalPercent = calorieGoal.calculateGoalPercent(total_calories, goal);
                solidGauge1.Value = goalPercent;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(username);
            profile.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void labelWalking_Click(object sender, EventArgs e)
        {
            Walking walking = new Walking(username);
            walking.ShowDialog();
            this.Close();
        }

        private void labelRunning_Click(object sender, EventArgs e)
        {
            Running running = new Running(username);
            running.ShowDialog();
            this.Close();
        }

        private void labelSwimming_Click(object sender, EventArgs e)
        {
            Swimming swimming = new Swimming(username);
            swimming.ShowDialog();
            this.Close();
        }

        private void labelYoga_Click(object sender, EventArgs e)
        {
            Yoga yoga = new Yoga(username);
            yoga.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History history = new History(username);
            history.ShowDialog();
            this.Close();
        }

        private void labelCycling_Click(object sender, EventArgs e)
        {
            Cycling cycling = new Cycling(username);
            cycling.ShowDialog();
            this.Close();
        }

        private void labelJumpRope_Click(object sender, EventArgs e)
        {
            JumpRope jumpRope = new JumpRope(username);
            jumpRope.ShowDialog();
            this.Close();
        }
    }
}
