using System.Windows.Forms;
using System;
using HotelReservationSystem.Assets;
using HotelReservationSystem.Theme;

namespace HotelReservationSystem.Login
{
    partial class SignupPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPanel));
            this.BackgroundPicture2 = new System.Windows.Forms.PictureBox();
            this.SignupLabel = new System.Windows.Forms.Label();
            this.HiLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.SignInLabel2 = new System.Windows.Forms.LinkLabel();
            this.SignInLabel1 = new System.Windows.Forms.Label();
            this.CreateButton = new HotelReservationSystem.Assets.RJButton();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPicture2
            // 
            this.BackgroundPicture2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPicture2.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundPicture2.Image")));
            this.BackgroundPicture2.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPicture2.Name = "BackgroundPicture2";
            this.BackgroundPicture2.Size = new System.Drawing.Size(900, 720);
            this.BackgroundPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackgroundPicture2.TabIndex = 0;
            this.BackgroundPicture2.TabStop = false;
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignupLabel.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SignupLabel.ForeColor = System.Drawing.Color.White;
            this.SignupLabel.Location = new System.Drawing.Point(505, 181);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(177, 19);
            this.SignupLabel.TabIndex = 12;
            this.SignupLabel.Text = "Create a new account.";
            // 
            // HiLabel
            // 
            this.HiLabel.AutoSize = true;
            this.HiLabel.BackColor = System.Drawing.Color.Transparent;
            this.HiLabel.Font = new System.Drawing.Font("SansSerif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.HiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.HiLabel.Location = new System.Drawing.Point(503, 150);
            this.HiLabel.Name = "HiLabel";
            this.HiLabel.Size = new System.Drawing.Size(120, 31);
            this.HiLabel.TabIndex = 11;
            this.HiLabel.Text = "Hi Love!";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(509, 367);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(287, 20);
            this.UsernameTextBox.TabIndex = 23;
            this.UsernameTextBox.Text = "Enter username...";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(506, 346);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(64, 14);
            this.UsernameLabel.TabIndex = 22;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(509, 425);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(287, 20);
            this.PasswordTextBox.TabIndex = 25;
            this.PasswordTextBox.Text = "Enter password...";
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(506, 404);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 14);
            this.PasswordLabel.TabIndex = 24;
            this.PasswordLabel.Text = "Password";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.FirstNameTextBox.Location = new System.Drawing.Point(509, 248);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(287, 20);
            this.FirstNameTextBox.TabIndex = 27;
            this.FirstNameTextBox.Text = "Enter first name...";
            this.FirstNameTextBox.Enter += new System.EventHandler(this.FirstNameTextBox_Enter);
            this.FirstNameTextBox.Leave += new System.EventHandler(this.FirstNameTextBox_Leave);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.White;
            this.FirstNameLabel.Location = new System.Drawing.Point(506, 227);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(66, 14);
            this.FirstNameLabel.TabIndex = 26;
            this.FirstNameLabel.Text = "First Name";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(509, 487);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(287, 20);
            this.ConfirmPasswordTextBox.TabIndex = 29;
            this.ConfirmPasswordTextBox.Text = "Confirm password...";
            this.ConfirmPasswordTextBox.Enter += new System.EventHandler(this.ConfimPasswordTextBox_Enter);
            this.ConfirmPasswordTextBox.Leave += new System.EventHandler(this.ConfimPasswordTextBox_Leave);
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(506, 466);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(107, 14);
            this.ConfirmPasswordLabel.TabIndex = 28;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // SignInLabel2
            // 
            this.SignInLabel2.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.SignInLabel2.AutoSize = true;
            this.SignInLabel2.BackColor = System.Drawing.Color.Transparent;
            this.SignInLabel2.Font = new System.Drawing.Font("SansSerif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SignInLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.SignInLabel2.Location = new System.Drawing.Point(695, 594);
            this.SignInLabel2.Name = "SignInLabel2";
            this.SignInLabel2.Size = new System.Drawing.Size(37, 12);
            this.SignInLabel2.TabIndex = 32;
            this.SignInLabel2.TabStop = true;
            this.SignInLabel2.Text = "Sign in";
            this.SignInLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInLabel2_LinkClicked);
            // 
            // SignInLabel1
            // 
            this.SignInLabel1.AutoSize = true;
            this.SignInLabel1.BackColor = System.Drawing.Color.Transparent;
            this.SignInLabel1.Font = new System.Drawing.Font("SansSerif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SignInLabel1.ForeColor = System.Drawing.Color.White;
            this.SignInLabel1.Location = new System.Drawing.Point(563, 594);
            this.SignInLabel1.Name = "SignInLabel1";
            this.SignInLabel1.Size = new System.Drawing.Size(132, 12);
            this.SignInLabel1.TabIndex = 31;
            this.SignInLabel1.Text = "Already have an account?";
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CreateButton.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.CreateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateButton.BorderRadius = 20;
            this.CreateButton.BorderSize = 0;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(568, 543);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(161, 39);
            this.CreateButton.TabIndex = 30;
            this.CreateButton.Text = "Create Account";
            this.CreateButton.TextColor = System.Drawing.Color.Black;
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.LastNameTextBox.Location = new System.Drawing.Point(509, 307);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(287, 20);
            this.LastNameTextBox.TabIndex = 34;
            this.LastNameTextBox.Text = "Enter last name...";
            this.LastNameTextBox.Enter += new System.EventHandler(this.LastNameTextBox_Enter);
            this.LastNameTextBox.Leave += new System.EventHandler(this.LastNameTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(506, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "Last Name";
            // 
            // SignupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignInLabel2);
            this.Controls.Add(this.SignInLabel1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SignupLabel);
            this.Controls.Add(this.HiLabel);
            this.Controls.Add(this.BackgroundPicture2);
            this.Name = "SignupPanel";
            this.Size = new System.Drawing.Size(900, 720);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundPicture2;
        private System.Windows.Forms.Label SignupLabel;
        private System.Windows.Forms.Label HiLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private Assets.RJButton CreateButton;
        private System.Windows.Forms.LinkLabel SignInLabel2;
        private System.Windows.Forms.Label SignInLabel1;
        private TextBox LastNameTextBox;
        private Label label1;
    }
}
