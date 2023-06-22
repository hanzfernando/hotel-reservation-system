namespace HotelReservationSystem.CheckInCheckOut
{
    partial class CheckInPanel
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
            this.CheckInGrid = new System.Windows.Forms.TableLayoutPanel();
            this.TopTablePanel = new System.Windows.Forms.Panel();
            this.TopButtonPanel = new System.Windows.Forms.Panel();
            this.artanPanel1 = new HotelReservationSystem.Assets.ArtanPanel();
            this.CheckInGrid.SuspendLayout();
            this.TopTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckInGrid
            // 
            this.CheckInGrid.ColumnCount = 1;
            this.CheckInGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CheckInGrid.Controls.Add(this.TopTablePanel, 0, 0);
            this.CheckInGrid.Controls.Add(this.TopButtonPanel, 0, 1);
            this.CheckInGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckInGrid.Location = new System.Drawing.Point(0, 0);
            this.CheckInGrid.Name = "CheckInGrid";
            this.CheckInGrid.RowCount = 2;
            this.CheckInGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.CheckInGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CheckInGrid.Size = new System.Drawing.Size(840, 840);
            this.CheckInGrid.TabIndex = 1;
            // 
            // TopTablePanel
            // 
            this.TopTablePanel.Controls.Add(this.artanPanel1);
            this.TopTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTablePanel.Location = new System.Drawing.Point(3, 3);
            this.TopTablePanel.Name = "TopTablePanel";
            this.TopTablePanel.Size = new System.Drawing.Size(834, 750);
            this.TopTablePanel.TabIndex = 0;
            // 
            // TopButtonPanel
            // 
            this.TopButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopButtonPanel.Location = new System.Drawing.Point(3, 759);
            this.TopButtonPanel.Name = "TopButtonPanel";
            this.TopButtonPanel.Size = new System.Drawing.Size(834, 78);
            this.TopButtonPanel.TabIndex = 1;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.artanPanel1.Location = new System.Drawing.Point(0, 0);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(834, 750);
            this.artanPanel1.TabIndex = 0;
            // 
            // CheckInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.CheckInGrid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CheckInPanel";
            this.Size = new System.Drawing.Size(840, 840);
            this.CheckInGrid.ResumeLayout(false);
            this.TopTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CheckInGrid;
        private System.Windows.Forms.Panel TopTablePanel;
        private System.Windows.Forms.Panel TopButtonPanel;
        private Assets.ArtanPanel artanPanel1;
    }
}
