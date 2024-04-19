namespace FinalAssignment
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.securityQuestions = new System.Windows.Forms.ComboBox();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundLabel.Location = new System.Drawing.Point(49, 108);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(304, 306);
            this.BackgroundLabel.TabIndex = 0;
            this.BackgroundLabel.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG IN";
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(78, 191);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(246, 31);
            this.textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(78, 239);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(246, 31);
            this.textPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(78, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOG IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(103, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click here to create an account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "FITNESS TRACKER APP";
            // 
            // securityQuestions
            // 
            this.securityQuestions.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityQuestions.FormattingEnabled = true;
            this.securityQuestions.Items.AddRange(new object[] {
            "What is your pets name?",
            "What is your best friend\'s name?",
            "What is your grandfather\'s name?"});
            this.securityQuestions.Location = new System.Drawing.Point(78, 191);
            this.securityQuestions.Name = "securityQuestions";
            this.securityQuestions.Size = new System.Drawing.Size(246, 33);
            this.securityQuestions.TabIndex = 7;
            this.securityQuestions.Visible = false;
            this.securityQuestions.SelectedIndexChanged += new System.EventHandler(this.securityQuestions_SelectedIndexChanged);
            // 
            // textAnswer
            // 
            this.textAnswer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnswer.Location = new System.Drawing.Point(78, 239);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(246, 31);
            this.textAnswer.TabIndex = 8;
            this.textAnswer.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(78, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.securityQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackgroundLabel);
            this.DoubleBuffered = true;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label BackgroundLabel;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textUsername;
        internal System.Windows.Forms.TextBox textPassword;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox securityQuestions;
        internal System.Windows.Forms.TextBox textAnswer;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}

