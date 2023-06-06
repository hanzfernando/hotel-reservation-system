namespace HotelReservationSystem.MainWindow
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TableLayoutNavigationRoot = new System.Windows.Forms.TableLayoutPanel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TableLayoutNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.DashboardTab = new System.Windows.Forms.Button();
            this.RoomsTab = new System.Windows.Forms.Button();
            this.ReservationTab = new System.Windows.Forms.Button();
            this.PanelRoot = new System.Windows.Forms.Panel();
            this.TableLayoutNavigationRoot.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TableLayoutNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutNavigationRoot
            // 
            this.TableLayoutNavigationRoot.BackColor = System.Drawing.SystemColors.Control;
            this.TableLayoutNavigationRoot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TableLayoutNavigationRoot.BackgroundImage")));
            this.TableLayoutNavigationRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TableLayoutNavigationRoot.ColumnCount = 1;
            this.TableLayoutNavigationRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutNavigationRoot.Controls.Add(this.LogoPanel, 0, 0);
            this.TableLayoutNavigationRoot.Controls.Add(this.TableLayoutNavigation, 0, 1);
            this.TableLayoutNavigationRoot.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutNavigationRoot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TableLayoutNavigationRoot.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutNavigationRoot.Name = "TableLayoutNavigationRoot";
            this.TableLayoutNavigationRoot.RowCount = 2;
            this.TableLayoutNavigationRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutNavigationRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TableLayoutNavigationRoot.Size = new System.Drawing.Size(300, 900);
            this.TableLayoutNavigationRoot.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPanel.Location = new System.Drawing.Point(3, 3);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(294, 129);
            this.LogoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TableLayoutNavigation
            // 
            this.TableLayoutNavigation.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutNavigation.ColumnCount = 1;
            this.TableLayoutNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutNavigation.Controls.Add(this.DashboardTab, 0, 0);
            this.TableLayoutNavigation.Controls.Add(this.ReservationTab, 0, 1);
            this.TableLayoutNavigation.Controls.Add(this.RoomsTab, 0, 2);
            this.TableLayoutNavigation.Location = new System.Drawing.Point(3, 138);
            this.TableLayoutNavigation.Name = "TableLayoutNavigation";
            this.TableLayoutNavigation.RowCount = 10;
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutNavigation.Size = new System.Drawing.Size(294, 759);
            this.TableLayoutNavigation.TabIndex = 2;
            // 
            // DashboardTab
            // 
            this.DashboardTab.BackColor = System.Drawing.Color.Transparent;
            this.DashboardTab.FlatAppearance.BorderSize = 0;
            this.DashboardTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.DashboardTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardTab.ForeColor = System.Drawing.Color.White;
            this.DashboardTab.Location = new System.Drawing.Point(3, 3);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.Size = new System.Drawing.Size(288, 69);
            this.DashboardTab.TabIndex = 0;
            this.DashboardTab.Text = "Dashboard";
            this.DashboardTab.UseVisualStyleBackColor = false;
            this.DashboardTab.Click += new System.EventHandler(this.DashboardTab_Click);
            // 
            // RoomsTab
            // 
            this.RoomsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomsTab.FlatAppearance.BorderSize = 0;
            this.RoomsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomsTab.ForeColor = System.Drawing.Color.White;
            this.RoomsTab.Location = new System.Drawing.Point(3, 153);
            this.RoomsTab.Name = "RoomsTab";
            this.RoomsTab.Size = new System.Drawing.Size(288, 69);
            this.RoomsTab.TabIndex = 2;
            this.RoomsTab.Text = "Rooms";
            this.RoomsTab.UseVisualStyleBackColor = true;
            // 
            // ReservationTab
            // 
            this.ReservationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservationTab.FlatAppearance.BorderSize = 0;
            this.ReservationTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationTab.ForeColor = System.Drawing.Color.White;
            this.ReservationTab.Location = new System.Drawing.Point(3, 78);
            this.ReservationTab.Name = "ReservationTab";
            this.ReservationTab.Size = new System.Drawing.Size(288, 69);
            this.ReservationTab.TabIndex = 1;
            this.ReservationTab.Text = "Reservation";
            this.ReservationTab.UseVisualStyleBackColor = true;
            // 
            // PanelRoot
            // 
            this.PanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoot.Location = new System.Drawing.Point(300, 0);
            this.PanelRoot.Name = "PanelRoot";
            this.PanelRoot.Size = new System.Drawing.Size(900, 900);
            this.PanelRoot.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.PanelRoot);
            this.Controls.Add(this.TableLayoutNavigationRoot);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.OnLoad);
            this.TableLayoutNavigationRoot.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TableLayoutNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelRoot;
        private System.Windows.Forms.Button DashboardTab;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutNavigationRoot;
        private System.Windows.Forms.TableLayoutPanel TableLayoutNavigation;
        private System.Windows.Forms.Button RoomsTab;
        private System.Windows.Forms.Button ReservationTab;
    }
}