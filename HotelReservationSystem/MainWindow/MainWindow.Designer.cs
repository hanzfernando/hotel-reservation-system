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
            this.CustomerStatusTab = new System.Windows.Forms.Button();
            this.TransactionsTab = new System.Windows.Forms.Button();
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
            this.TableLayoutNavigationRoot.ColumnCount = 2;
            this.TableLayoutNavigationRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutNavigationRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableLayoutNavigationRoot.Controls.Add(this.LogoPanel, 0, 0);
            this.TableLayoutNavigationRoot.Controls.Add(this.TableLayoutNavigation, 1, 0);
            this.TableLayoutNavigationRoot.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutNavigationRoot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TableLayoutNavigationRoot.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutNavigationRoot.Name = "TableLayoutNavigationRoot";
            this.TableLayoutNavigationRoot.RowCount = 1;
            this.TableLayoutNavigationRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutNavigationRoot.Size = new System.Drawing.Size(1200, 60);
            this.TableLayoutNavigationRoot.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPanel.Location = new System.Drawing.Point(3, 3);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(234, 54);
            this.LogoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TableLayoutNavigation
            // 
            this.TableLayoutNavigation.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutNavigation.ColumnCount = 5;
            this.TableLayoutNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutNavigation.Controls.Add(this.DashboardTab, 0, 0);
            this.TableLayoutNavigation.Controls.Add(this.RoomsTab, 1, 0);
            this.TableLayoutNavigation.Controls.Add(this.CustomerStatusTab, 2, 0);
            this.TableLayoutNavigation.Controls.Add(this.TransactionsTab, 3, 0);
            this.TableLayoutNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutNavigation.Location = new System.Drawing.Point(243, 3);
            this.TableLayoutNavigation.Name = "TableLayoutNavigation";
            this.TableLayoutNavigation.RowCount = 1;
            this.TableLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutNavigation.Size = new System.Drawing.Size(954, 54);
            this.TableLayoutNavigation.TabIndex = 2;
            // 
            // DashboardTab
            // 
            this.DashboardTab.BackColor = System.Drawing.Color.Transparent;
            this.DashboardTab.FlatAppearance.BorderSize = 0;
            this.DashboardTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardTab.ForeColor = System.Drawing.Color.White;
            this.DashboardTab.Location = new System.Drawing.Point(3, 3);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.Size = new System.Drawing.Size(184, 48);
            this.DashboardTab.TabIndex = 0;
            this.DashboardTab.Text = "Dashboard";
            this.DashboardTab.UseVisualStyleBackColor = false;
            // 
            // RoomsTab
            // 
            this.RoomsTab.BackColor = System.Drawing.Color.Transparent;
            this.RoomsTab.FlatAppearance.BorderSize = 0;
            this.RoomsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomsTab.ForeColor = System.Drawing.Color.White;
            this.RoomsTab.Location = new System.Drawing.Point(193, 3);
            this.RoomsTab.Name = "RoomsTab";
            this.RoomsTab.Size = new System.Drawing.Size(184, 48);
            this.RoomsTab.TabIndex = 1;
            this.RoomsTab.Text = "Rooms";
            this.RoomsTab.UseVisualStyleBackColor = true;
            // 
            // CustomerStatusTab
            // 
            this.CustomerStatusTab.BackColor = System.Drawing.Color.Transparent;
            this.CustomerStatusTab.FlatAppearance.BorderSize = 0;
            this.CustomerStatusTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerStatusTab.ForeColor = System.Drawing.Color.White;
            this.CustomerStatusTab.Location = new System.Drawing.Point(383, 3);
            this.CustomerStatusTab.Name = "CustomerStatusTab";
            this.CustomerStatusTab.Size = new System.Drawing.Size(184, 48);
            this.CustomerStatusTab.TabIndex = 2;
            this.CustomerStatusTab.Text = "Customer Status";
            this.CustomerStatusTab.UseVisualStyleBackColor = true;
            // 
            // TransactionsTab
            // 
            this.TransactionsTab.BackColor = System.Drawing.Color.Transparent;
            this.TransactionsTab.FlatAppearance.BorderSize = 0;
            this.TransactionsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsTab.ForeColor = System.Drawing.Color.White;
            this.TransactionsTab.Location = new System.Drawing.Point(573, 3);
            this.TransactionsTab.Name = "TransactionsTab";
            this.TransactionsTab.Size = new System.Drawing.Size(184, 48);
            this.TransactionsTab.TabIndex = 3;
            this.TransactionsTab.Text = "Transactions";
            this.TransactionsTab.UseVisualStyleBackColor = true;
            // 
            // PanelRoot
            // 
            this.PanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoot.Location = new System.Drawing.Point(0, 60);
            this.PanelRoot.Name = "PanelRoot";
            this.PanelRoot.Size = new System.Drawing.Size(1200, 840);
            this.PanelRoot.TabIndex = 1;
            this.PanelRoot.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRoot_Paint);
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
            this.TableLayoutNavigationRoot.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TableLayoutNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutNavigationRoot;
        private System.Windows.Forms.TableLayoutPanel TableLayoutNavigation;
        private System.Windows.Forms.Panel PanelRoot;
        private System.Windows.Forms.Button DashboardTab;
        private System.Windows.Forms.Button RoomsTab;
        private System.Windows.Forms.Button CustomerStatusTab;
        private System.Windows.Forms.Button TransactionsTab;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}