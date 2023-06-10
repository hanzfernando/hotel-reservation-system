namespace HotelReservationSystem.Reservation
{
    partial class ReservationWindow
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
            this.createReservationPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // createReservationPanel
            // 
            this.createReservationPanel.Location = new System.Drawing.Point(2, 1);
            this.createReservationPanel.Name = "createReservationPanel";
            this.createReservationPanel.Size = new System.Drawing.Size(500, 675);
            this.createReservationPanel.TabIndex = 0;
            // 
            // ReservationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 676);
            this.Controls.Add(this.createReservationPanel);
            this.Name = "ReservationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationWindow";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel createReservationPanel;
    }
}