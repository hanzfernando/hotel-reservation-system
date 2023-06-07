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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ConfimPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.SignInLabel2 = new System.Windows.Forms.LinkLabel();
            this.SignInLabel1 = new System.Windows.Forms.Label();
            this.LoginButton = new HotelReservationSystem.Assets.RJButton();
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
            this.UsernameTextBox.Location = new System.Drawing.Point(509, 260);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(287, 20);
            this.UsernameTextBox.TabIndex = 23;
            this.UsernameTextBox.Text = "Enter Username...";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(506, 239);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(64, 14);
            this.UsernameLabel.TabIndex = 22;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(509, 389);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(287, 20);
            this.PasswordTextBox.TabIndex = 25;
            this.PasswordTextBox.Text = "Enter Password...";
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(506, 368);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 14);
            this.PasswordLabel.TabIndex = 24;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.EmailTextBox.Location = new System.Drawing.Point(509, 322);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(287, 20);
            this.EmailTextBox.TabIndex = 27;
            this.EmailTextBox.Text = "Enter Email...";
            this.EmailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(506, 301);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 14);
            this.EmailLabel.TabIndex = 26;
            this.EmailLabel.Text = "Email";
            // 
            // ConfimPasswordTextBox
            // 
            this.ConfimPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.ConfimPasswordTextBox.Location = new System.Drawing.Point(509, 454);
            this.ConfimPasswordTextBox.Name = "ConfimPasswordTextBox";
            this.ConfimPasswordTextBox.Size = new System.Drawing.Size(287, 20);
            this.ConfimPasswordTextBox.TabIndex = 29;
            this.ConfimPasswordTextBox.Text = "Enter Password...";
            this.ConfimPasswordTextBox.Enter += new System.EventHandler(this.ConfimPasswordTextBox_Enter);
            this.ConfimPasswordTextBox.Leave += new System.EventHandler(this.ConfimPasswordTextBox_Leave);
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(506, 433);
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
            this.SignInLabel2.Location = new System.Drawing.Point(695, 561);
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
            this.SignInLabel1.Location = new System.Drawing.Point(563, 561);
            this.SignInLabel1.Name = "SignInLabel1";
            this.SignInLabel1.Size = new System.Drawing.Size(132, 12);
            this.SignInLabel1.TabIndex = 31;
            this.SignInLabel1.Text = "Already have an account?";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LoginButton.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.LoginButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.LoginButton.BorderRadius = 20;
            this.LoginButton.BorderSize = 0;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(568, 513);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(161, 39);
            this.LoginButton.TabIndex = 30;
            this.LoginButton.Text = "Create Account";
            this.LoginButton.TextColor = System.Drawing.Color.Black;
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // SignupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.SignInLabel2);
            this.Controls.Add(this.SignInLabel1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ConfimPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
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
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox ConfimPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private Assets.RJButton LoginButton;
        private System.Windows.Forms.LinkLabel SignInLabel2;
        private System.Windows.Forms.Label SignInLabel1;
    }
}
