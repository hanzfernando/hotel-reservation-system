using System.Windows.Forms;
using System;
using HotelReservationSystem.Assets;
using HotelReservationSystem.Theme;

namespace HotelReservationSystem.Login
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BackgroundPicture = new System.Windows.Forms.PictureBox();
            this.SigninLabel = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.CreateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new HotelReservationSystem.Assets.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("SansSerif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(91, 173);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(141, 31);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome!";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(97, 280);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(64, 14);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(96, 379);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 14);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // BackgroundPicture
            // 
            this.BackgroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPicture.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundPicture.Image")));
            this.BackgroundPicture.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPicture.Name = "BackgroundPicture";
            this.BackgroundPicture.Size = new System.Drawing.Size(900, 720);
            this.BackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackgroundPicture.TabIndex = 9;
            this.BackgroundPicture.TabStop = false;
            // 
            // SigninLabel
            // 
            this.SigninLabel.AutoSize = true;
            this.SigninLabel.BackColor = System.Drawing.Color.Transparent;
            this.SigninLabel.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SigninLabel.ForeColor = System.Drawing.Color.White;
            this.SigninLabel.Location = new System.Drawing.Point(93, 204);
            this.SigninLabel.Name = "SigninLabel";
            this.SigninLabel.Size = new System.Drawing.Size(190, 19);
            this.SigninLabel.TabIndex = 10;
            this.SigninLabel.Text = "Sign in to your account.";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("SansSerif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(100, 441);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(89, 14);
            this.ShowPasswordCheckBox.TabIndex = 16;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateLabel.Font = new System.Drawing.Font("SansSerif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CreateLabel.ForeColor = System.Drawing.Color.White;
            this.CreateLabel.Location = new System.Drawing.Point(164, 543);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(120, 12);
            this.CreateLabel.TabIndex = 17;
            this.CreateLabel.Text = "Don\'t have an account?";
            // 
            // CreateLinkLabel
            // 
            this.CreateLinkLabel.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.CreateLinkLabel.AutoSize = true;
            this.CreateLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateLinkLabel.Font = new System.Drawing.Font("SansSerif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CreateLinkLabel.LinkColor = System.Drawing.Color.Yellow;
            this.CreateLinkLabel.Location = new System.Drawing.Point(284, 543);
            this.CreateLinkLabel.Name = "CreateLinkLabel";
            this.CreateLinkLabel.Size = new System.Drawing.Size(38, 12);
            this.CreateLinkLabel.TabIndex = 18;
            this.CreateLinkLabel.TabStop = true;
            this.CreateLinkLabel.Text = "Create";
            this.CreateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateLinkLabel_LinkClicked);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(100, 307);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(287, 20);
            this.UsernameTextBox.TabIndex = 21;
            this.UsernameTextBox.Text = "Enter Username...";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(100, 406);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(287, 20);
            this.PasswordTextBox.TabIndex = 22;
            this.PasswordTextBox.Text = "Enter Password...";
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
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
            this.LoginButton.Location = new System.Drawing.Point(161, 496);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(161, 39);
            this.LoginButton.TabIndex = 15;
            this.LoginButton.Text = "Sign in";
            this.LoginButton.TextColor = System.Drawing.Color.Black;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.CreateLinkLabel);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SigninLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.BackgroundPicture);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(900, 720);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox BackgroundPicture;
        private Label SigninLabel;
        private RJButton LoginButton;
        private CheckBox ShowPasswordCheckBox;
        private Label CreateLabel;
        private LinkLabel CreateLinkLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
    }
}
