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
    public partial class RegistrationForm : Form
    {
        //Constructor
        public RegistrationForm()
        {
            InitializeComponent();
        }

        //Declaring a global variable
        Boolean pictureBoxFlag1 = false, pictureBoxFlag2 = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Method to go to the LoginForm.cs class
        private void label14_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            obj.ShowDialog();
            this.Hide();
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            //Declaring the Initializing variables used in the method
            String firstName = textFirstName.Text, lastName = textLastName.Text, email = textEmail.Text, gender = genderComboBox.Text, securityQ = securityQuesiton.Text, username = textUsername.Text, password = textPassword.Text, repass = textReenteredPassword.Text, answer = textAnswer.Text;
            int height = int.Parse(textHeight.Text), weight = int.Parse(textWeight.Text), counter1 = 0, counter2 = 0;
            long phoneNumber = long.Parse(textNumber.Text);
            bool inputResult;

            //Declaring and Initializing the object of classes used in the method
            InsertOperations insertOperations = new InsertOperations();

            //Verifying the password length
            if (password.Length < 12)
            {
                password = "";
                textPassword.Text = "";
                MessageBox.Show("The password must contain atleast 12 letters.");
                return;
            }
            else
            {
                //Verifying that password has an Uppercase and one Lowercase letter
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        counter1 += 1;
                    else
                        counter2 += 1;
                }
                if (counter1 <= 0 || counter2 <= 0)
                {
                    password = "";
                    textPassword.Text = "";
                    MessageBox.Show("The password must contain atleast one uppercase and one lowercase letter.");
                    return;
                }
            }

            //Verifying that username only contains letters and digits
            foreach (char c in username)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                    continue;
                else
                {
                    username = "";
                    textUsername.Text = "";
                    MessageBox.Show("The username should only contain letters and digits.");
                    return;
                }
            }

            //Verifying that the password and re-entered password match
            if (password != repass)
            {
                MessageBox.Show("The entered passwords should match.");
                return;
            }

            //Inserting the details of the user in the UserInformation table of the database
            inputResult = insertOperations.insertIntoUserInformation(firstName, lastName, height, weight, phoneNumber, email, gender, username, password, securityQ, answer);

            //Verifying that the user details have been recorded in the database successfully
            if (inputResult)
            {
                MessageBox.Show("Registration Completed.");
                HomePage homePage = new HomePage(username);
                homePage.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Registration failed." + inputResult);
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        //Method to show and hide the password
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBoxFlag1)
            {
                textPassword.PasswordChar = '*';
                pictureBox1.ImageLocation = "C:\\Users\\Asus\\OneDrive\\Desktop\\VIIE Sem 2\\Designing Object Oriented Computer Program\\Final Assignment Documentation\\Images\\HidePasswordIcon.png";
                pictureBoxFlag1 = false;
            }
            else
            {
                textPassword.PasswordChar = '\0';
                pictureBox1.ImageLocation = "C:\\Users\\Asus\\OneDrive\\Desktop\\VIIE Sem 2\\Designing Object Oriented Computer Program\\Final Assignment Documentation\\Images\\ShowPasswordIcon.png";
                pictureBoxFlag1 = true;
            }
        }

        //Method to show and hide the password
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBoxFlag2)
            {
                textReenteredPassword.PasswordChar = '*';
                pictureBox2.ImageLocation = "C:\\Users\\Asus\\OneDrive\\Desktop\\VIIE Sem 2\\Designing Object Oriented Computer Program\\Final Assignment Documentation\\Images\\HidePasswordIcon.png";
                pictureBoxFlag2 = false;
            }
            else
            {
                textReenteredPassword.PasswordChar = '\0';
                pictureBox2.ImageLocation = "C:\\Users\\Asus\\OneDrive\\Desktop\\VIIE Sem 2\\Designing Object Oriented Computer Program\\Final Assignment Documentation\\Images\\ShowPasswordIcon.png";
                pictureBoxFlag2 = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
