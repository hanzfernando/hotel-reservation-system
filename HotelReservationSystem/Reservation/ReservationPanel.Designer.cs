namespace HotelReservationSystem.Reservation
{
    partial class ReservationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationPanel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.ReservationLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PinkBG = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton1 = new HotelReservationSystem.Assets.RJButton();
            this.CreateButton = new HotelReservationSystem.Assets.RJButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PinkBG)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 900);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListPanel);
            this.panel1.Controls.Add(this.PinkBG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 70, 30, 30);
            this.panel1.Size = new System.Drawing.Size(894, 804);
            this.panel1.TabIndex = 0;
            // 
            // ListPanel
            // 
            this.ListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListPanel.Controls.Add(this.ReservationLayoutPanel);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(30, 70);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.ListPanel.Size = new System.Drawing.Size(834, 704);
            this.ListPanel.TabIndex = 2;
            // 
            // ReservationLayoutPanel
            // 
            this.ReservationLayoutPanel.AutoScroll = true;
            this.ReservationLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ReservationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservationLayoutPanel.Location = new System.Drawing.Point(30, 30);
            this.ReservationLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ReservationLayoutPanel.Name = "ReservationLayoutPanel";
            this.ReservationLayoutPanel.Size = new System.Drawing.Size(774, 674);
            this.ReservationLayoutPanel.TabIndex = 1;
            // 
            // PinkBG
            // 
            this.PinkBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PinkBG.Image = ((System.Drawing.Image)(resources.GetObject("PinkBG.Image")));
            this.PinkBG.Location = new System.Drawing.Point(30, 70);
            this.PinkBG.Margin = new System.Windows.Forms.Padding(0);
            this.PinkBG.Name = "PinkBG";
            this.PinkBG.Size = new System.Drawing.Size(834, 704);
            this.PinkBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PinkBG.TabIndex = 0;
            this.PinkBG.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.CreateButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 813);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 84);
            this.panel2.TabIndex = 1;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundColor = System.Drawing.Color.White;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(777, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(87, 40);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Cancel";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.White;
            this.CreateButton.BackgroundColor = System.Drawing.Color.White;
            this.CreateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateButton.BorderRadius = 20;
            this.CreateButton.BorderSize = 0;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(667, 3);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(86, 40);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create";
            this.CreateButton.TextColor = System.Drawing.Color.Black;
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReservationPanel";
            this.Size = new System.Drawing.Size(900, 900);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PinkBG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Assets.RJButton CreateButton;
        private Assets.RJButton rjButton1;
        private System.Windows.Forms.PictureBox PinkBG;
        private System.Windows.Forms.FlowLayoutPanel ReservationLayoutPanel;
        private System.Windows.Forms.Panel ListPanel;
    }
}
