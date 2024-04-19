﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
    public partial class LoginForm : Form
    {
        public static String lastMessageBoxShownMessage;
        public LoginForm()
        {
            InitializeComponent();
        }

        ValidateUser obj = new ValidateUser();
        RegistrationForm registrationForm = new RegistrationForm();

        int loginCounter = 0;
        
        Boolean pictureBoxFlag = false;

        public void label2_Click(object sender, EventArgs e)
        {
            registrationForm.ShowDialog();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            bool result;

            if (loginCounter < 3)
            {
                result = obj.validateUser(textUsername.Text, textPassword.Text);

                if (result)
                {
                    MessageBox.Show("Login Successful");
                    lastMessageBoxShownMessage = "Login Successful";
                    HomePage homePage = new HomePage(textUsername.Text);
                    homePage.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Unsuccessful");
                    lastMessageBoxShownMessage = "Login Unsuccessful";
                    textPassword.Text = "";
                    loginCounter++;
                }
            }
            else
            {
                MessageBox.Show("You have entered the wrong credentials 3 times due to which your account has been locked.\nIn order to unlock your account answer the security question correctly.");
                lastMessageBoxShownMessage = "You have entered the wrong credentials 3 times due to which your account has been locked.\nIn order to unlock your account answer the security question correctly.";
                textUsername.Visible = false;
                textPassword.Visible = false;
                securityQuestions.Visible = true;
                textAnswer.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Boolean result;
            result = obj.validateAnswer(textAnswer.Text, textUsername.Text);

            if (result)
            {
                textUsername.Visible = true;
                textPassword.Visible = true;
                button1.Visible=true;
                pictureBox1.Visible=true;
                securityQuestions.Visible = false;
                textAnswer.Visible = false;
                button2.Visible = false;
                loginCounter = 0;
            }
            else
            {
                MessageBox.Show("Wrong Answer.");
                lastMessageBoxShownMessage = "Wrong Answer.";
            }
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBoxFlag)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Asus\\OneDrive\\Desktop\\VIIE Sem 2\\Designing Object Oriented Computer Program\\Final Assignment Documentation\\Images\\HidePasswordIcon.png";
                textPassword.PasswordChar = '*';
                pictureBoxFlag = false;
            }
            else
            {
                pictureBox1.ImageLocation = "C:\\Users\\Asus\\OneDrive\\Desktop\\VIIE Sem 2\\Designing Object Oriented Computer Program\\Final Assignment Documentation\\Images\\ShowPasswordIcon.png";
                textPassword.PasswordChar = '\0';
                pictureBoxFlag = true;
            }
        }

        public void LoginForm_Load(object sender, EventArgs e)
        {
            textUsername.Visible = true;
            textPassword.Visible = true;
            button1.Visible = true;
            pictureBox1.Visible = true;
            securityQuestions.Visible = false;
            textAnswer.Visible = false;
            button2.Visible = false;
        }

        public void securityQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
