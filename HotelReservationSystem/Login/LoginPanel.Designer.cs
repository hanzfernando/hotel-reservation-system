using System.Windows.Forms;
using System;

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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BackgroundPicture = new System.Windows.Forms.PictureBox();
            this.LoginButton = new HotelReservationSystem.Assets.RJButton();
            this.UsernameTextbox = new HotelReservationSystem.Assets.PlaceHolderTextbox();
            this.PasswordTextbox = new HotelReservationSystem.Assets.PlaceHolderTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("SansSerif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(115, 173);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(191, 31);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Administrator";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(118, 281);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(76, 17);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(118, 379);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(74, 17);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
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
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.BorderColor = System.Drawing.Color.White;
            this.LoginButton.BorderRadius = 12;
            this.LoginButton.BorderSize = 0;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(170, 511);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(162, 34);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextColor = System.Drawing.Color.Black;
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("SansSerif", 9.749999F);
            this.UsernameTextbox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTextbox.Location = new System.Drawing.Point(121, 309);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PlaceHolderText = "Enter Username ...";
            this.UsernameTextbox.Size = new System.Drawing.Size(275, 23);
            this.UsernameTextbox.TabIndex = 13;
            this.UsernameTextbox.Text = "Enter Username ...";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextbox.Location = new System.Drawing.Point(121, 409);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PlaceHolderText = "Enter Password ...";
            this.PasswordTextbox.Size = new System.Drawing.Size(275, 23);
            this.PasswordTextbox.TabIndex = 14;
            this.PasswordTextbox.Text = "Enter Password ...";
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BackgroundPicture);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(900, 720);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox BackgroundPicture;
        private Assets.RJButton LoginButton;
        private Assets.PlaceHolderTextbox UsernameTextbox;
        private Assets.PlaceHolderTextbox PasswordTextbox;
    }
}
