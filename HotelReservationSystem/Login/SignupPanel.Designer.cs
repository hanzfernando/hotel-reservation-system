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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignupLabel = new System.Windows.Forms.Label();
            this.HiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // SignupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.SignupLabel);
            this.Controls.Add(this.HiLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SignupPanel";
            this.Size = new System.Drawing.Size(900, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SignupLabel;
        private System.Windows.Forms.Label HiLabel;
    }
}
