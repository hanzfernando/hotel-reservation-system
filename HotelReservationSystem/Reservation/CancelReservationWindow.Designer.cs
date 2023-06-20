namespace HotelReservationSystem.Reservation
{
    partial class CancelReservationWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.YesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CancelQuestionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.YesLinkLabel);
            this.panel1.Controls.Add(this.CancelQuestionLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 120);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.linkLabel1.Location = new System.Drawing.Point(108, 85);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(23, 14);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "No";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoLinkLabel_LinkClicked);
            // 
            // YesLinkLabel
            // 
            this.YesLinkLabel.AutoSize = true;
            this.YesLinkLabel.Font = new System.Drawing.Font("SansSerif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.YesLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(5)))));
            this.YesLinkLabel.Location = new System.Drawing.Point(39, 85);
            this.YesLinkLabel.Name = "YesLinkLabel";
            this.YesLinkLabel.Size = new System.Drawing.Size(28, 14);
            this.YesLinkLabel.TabIndex = 4;
            this.YesLinkLabel.TabStop = true;
            this.YesLinkLabel.Text = "Yes";
            this.YesLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(5)))));
            this.YesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YesLinkLabel_LinkClicked);
            // 
            // CancelQuestionLabel
            // 
            this.CancelQuestionLabel.AutoSize = true;
            this.CancelQuestionLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CancelQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.CancelQuestionLabel.Location = new System.Drawing.Point(29, 22);
            this.CancelQuestionLabel.Name = "CancelQuestionLabel";
            this.CancelQuestionLabel.Size = new System.Drawing.Size(116, 45);
            this.CancelQuestionLabel.TabIndex = 3;
            this.CancelQuestionLabel.Text = "Are you sure you\r\nwant to cancel this\r\nreservation?";
            this.CancelQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelReservationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 120);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelReservationWindow";
            this.Text = "CancelReservationWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel YesLinkLabel;
        private System.Windows.Forms.Label CancelQuestionLabel;
    }
}