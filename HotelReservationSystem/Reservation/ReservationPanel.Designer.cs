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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationPanel));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.artanPanel1 = new HotelReservationSystem.Assets.ArtanPanel();
            this.ReservationDataGridView = new System.Windows.Forms.DataGridView();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.CreateButton = new HotelReservationSystem.Assets.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderByComboBox = new HotelReservationSystem.Assets.RJComboBox();
            this.SortByComboBox = new HotelReservationSystem.Assets.RJComboBox();
            this.FilterByComboBox = new HotelReservationSystem.Assets.RJComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.TableLayoutPanel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataGridView)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.TopPanel, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.BottomPanel, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1300, 900);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.artanPanel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(3, 93);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(30);
            this.TopPanel.Size = new System.Drawing.Size(1294, 714);
            this.TopPanel.TabIndex = 0;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.ReservationDataGridView);
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(154)))), ((int)(((byte)(237)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(154)))), ((int)(((byte)(237)))));
            this.artanPanel1.Location = new System.Drawing.Point(30, 30);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.artanPanel1.Size = new System.Drawing.Size(1234, 654);
            this.artanPanel1.TabIndex = 0;
            // 
            // ReservationDataGridView
            // 
            this.ReservationDataGridView.AllowUserToAddRows = false;
            this.ReservationDataGridView.AllowUserToDeleteRows = false;
            this.ReservationDataGridView.AllowUserToResizeColumns = false;
            this.ReservationDataGridView.AllowUserToResizeRows = false;
            this.ReservationDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ReservationDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(154)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(154)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReservationDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SansSerif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReservationDataGridView.EnableHeadersVisualStyles = false;
            this.ReservationDataGridView.Location = new System.Drawing.Point(6, 2);
            this.ReservationDataGridView.Name = "ReservationDataGridView";
            this.ReservationDataGridView.ReadOnly = true;
            this.ReservationDataGridView.RowHeadersVisible = false;
            this.ReservationDataGridView.RowHeadersWidth = 35;
            this.ReservationDataGridView.RowTemplate.Height = 25;
            this.ReservationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationDataGridView.Size = new System.Drawing.Size(1225, 729);
            this.ReservationDataGridView.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.CreateButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(3, 813);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1294, 84);
            this.BottomPanel.TabIndex = 1;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CreateButton.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.CreateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateButton.BorderRadius = 20;
            this.CreateButton.BorderSize = 0;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(1164, 0);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 40);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create";
            this.CreateButton.TextColor = System.Drawing.Color.Black;
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrderByComboBox);
            this.panel1.Controls.Add(this.SortByComboBox);
            this.panel1.Controls.Add(this.FilterByComboBox);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 84);
            this.panel1.TabIndex = 2;
            // 
            // OrderByComboBox
            // 
            this.OrderByComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OrderByComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.OrderByComboBox.BorderSize = 0;
            this.OrderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderByComboBox.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.OrderByComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.OrderByComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.OrderByComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.OrderByComboBox.ListBackColor = System.Drawing.Color.White;
            this.OrderByComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.OrderByComboBox.Location = new System.Drawing.Point(778, 53);
            this.OrderByComboBox.MinimumSize = new System.Drawing.Size(200, 26);
            this.OrderByComboBox.Name = "OrderByComboBox";
            this.OrderByComboBox.Size = new System.Drawing.Size(200, 26);
            this.OrderByComboBox.TabIndex = 5;
            this.OrderByComboBox.Texts = "Ascending";
            // 
            // SortByComboBox
            // 
            this.SortByComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortByComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.SortByComboBox.BorderSize = 0;
            this.SortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortByComboBox.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SortByComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.SortByComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.SortByComboBox.Items.AddRange(new object[] {
            "Id",
            "Transaction Date",
            "Check In Date",
            "Check Out Date"});
            this.SortByComboBox.ListBackColor = System.Drawing.Color.White;
            this.SortByComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.SortByComboBox.Location = new System.Drawing.Point(556, 53);
            this.SortByComboBox.MinimumSize = new System.Drawing.Size(200, 26);
            this.SortByComboBox.Name = "SortByComboBox";
            this.SortByComboBox.Size = new System.Drawing.Size(200, 26);
            this.SortByComboBox.TabIndex = 4;
            this.SortByComboBox.Texts = "Id";
            // 
            // FilterByComboBox
            // 
            this.FilterByComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FilterByComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.FilterByComboBox.BorderSize = 0;
            this.FilterByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByComboBox.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FilterByComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.FilterByComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.FilterByComboBox.Items.AddRange(new object[] {
            "Status (All)",
            "Reserved",
            "Checked In",
            "Checked Out"});
            this.FilterByComboBox.ListBackColor = System.Drawing.Color.White;
            this.FilterByComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.FilterByComboBox.Location = new System.Drawing.Point(334, 53);
            this.FilterByComboBox.MinimumSize = new System.Drawing.Size(200, 26);
            this.FilterByComboBox.Name = "FilterByComboBox";
            this.FilterByComboBox.Size = new System.Drawing.Size(200, 26);
            this.FilterByComboBox.TabIndex = 3;
            this.FilterByComboBox.Texts = "Status (All)";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(46)))), ((int)(((byte)(136)))));
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(278, 53);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.SearchButton.Size = new System.Drawing.Size(27, 26);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SearchTextBox.Location = new System.Drawing.Point(30, 53);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(249, 26);
            this.SearchTextBox.TabIndex = 0;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // ReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "ReservationPanel";
            this.Size = new System.Drawing.Size(1300, 900);
            this.Load += new System.EventHandler(this.ReservationPanel_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.artanPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataGridView)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Panel TopPanel;
        private Assets.ArtanPanel artanPanel1;
        private System.Windows.Forms.DataGridView ReservationDataGridView;
        private System.Windows.Forms.Panel BottomPanel;
        private Assets.RJButton CreateButton;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private Assets.RJComboBox FilterByComboBox;
        private Assets.RJComboBox SortByComboBox;
        private Assets.RJComboBox OrderByComboBox;
    }
}
