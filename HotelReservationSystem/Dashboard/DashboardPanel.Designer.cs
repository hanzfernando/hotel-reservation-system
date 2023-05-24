namespace HotelReservationSystem.Dashboard
{
    partial class DashboardPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPanel));
            this.DashboardTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableLayoutNavigationDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DashboardTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardTableLayout
            // 
            this.DashboardTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashboardTableLayout.ColumnCount = 2;
            this.DashboardTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DashboardTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.DashboardTableLayout.Controls.Add(this.panel1, 0, 0);
            this.DashboardTableLayout.Controls.Add(this.dateTimePicker1, 1, 0);
            this.DashboardTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardTableLayout.Location = new System.Drawing.Point(0, 0);
            this.DashboardTableLayout.Name = "DashboardTableLayout";
            this.DashboardTableLayout.RowCount = 1;
            this.DashboardTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DashboardTableLayout.Size = new System.Drawing.Size(1200, 840);
            this.DashboardTableLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TableLayoutNavigationDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 840);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TableLayoutNavigationDashboard
            // 
            this.TableLayoutNavigationDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutNavigationDashboard.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutNavigationDashboard.ColumnCount = 1;
            this.TableLayoutNavigationDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutNavigationDashboard.Location = new System.Drawing.Point(30, 30);
            this.TableLayoutNavigationDashboard.Margin = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.TableLayoutNavigationDashboard.Name = "TableLayoutNavigationDashboard";
            this.TableLayoutNavigationDashboard.RowCount = 4;
            this.TableLayoutNavigationDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.TableLayoutNavigationDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.TableLayoutNavigationDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.TableLayoutNavigationDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutNavigationDashboard.Size = new System.Drawing.Size(180, 810);
            this.TableLayoutNavigationDashboard.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 810);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.DashboardTableLayout);
            this.Name = "DashboardPanel";
            this.Size = new System.Drawing.Size(1200, 840);
            this.DashboardTableLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel DashboardTableLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutNavigationDashboard;
    }
}
