namespace HotelReservationSystem.Reservation
{
    partial class CreateReservationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReservationPanel));
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.CreateReservationLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.RoomUnitTextBox = new System.Windows.Forms.TextBox();
            this.RoomUnitLabel = new System.Windows.Forms.Label();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.SuffixTextBox = new System.Windows.Forms.TextBox();
            this.SuffixLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.CreateRecordButton = new HotelReservationSystem.Assets.RJButton();
            this.CheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDateLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(0, 46);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(500, 108);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // CreateReservationLabel
            // 
            this.CreateReservationLabel.AutoSize = true;
            this.CreateReservationLabel.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CreateReservationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.CreateReservationLabel.Location = new System.Drawing.Point(143, 157);
            this.CreateReservationLabel.Name = "CreateReservationLabel";
            this.CreateReservationLabel.Size = new System.Drawing.Size(206, 25);
            this.CreateReservationLabel.TabIndex = 1;
            this.CreateReservationLabel.Text = "Create Reservation";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.White;
            this.FirstNameLabel.Location = new System.Drawing.Point(26, 221);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(71, 15);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.FirstNameTextBox.Location = new System.Drawing.Point(29, 249);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.FirstNameTextBox.TabIndex = 3;
            this.FirstNameTextBox.Text = "Enter first name...";
            this.FirstNameTextBox.Enter += new System.EventHandler(this.FirstNameTextBox_Enter);
            this.FirstNameTextBox.Leave += new System.EventHandler(this.FirstNameTextBox_Leave);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.LastNameTextBox.Location = new System.Drawing.Point(29, 311);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.LastNameTextBox.TabIndex = 5;
            this.LastNameTextBox.Text = "Enter last name...";
            this.LastNameTextBox.Enter += new System.EventHandler(this.LastNameTextBox_Enter);
            this.LastNameTextBox.Leave += new System.EventHandler(this.LastNameTextBox_Leave);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.White;
            this.LastNameLabel.Location = new System.Drawing.Point(26, 283);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(70, 15);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CheckInLabel.ForeColor = System.Drawing.Color.White;
            this.CheckInLabel.Location = new System.Drawing.Point(26, 473);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(59, 15);
            this.CheckInLabel.TabIndex = 8;
            this.CheckInLabel.Text = "Check In";
            // 
            // RoomUnitTextBox
            // 
            this.RoomUnitTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.RoomUnitTextBox.Location = new System.Drawing.Point(29, 440);
            this.RoomUnitTextBox.Name = "RoomUnitTextBox";
            this.RoomUnitTextBox.Size = new System.Drawing.Size(196, 20);
            this.RoomUnitTextBox.TabIndex = 7;
            this.RoomUnitTextBox.Text = "Enter room unit...";
            this.RoomUnitTextBox.Enter += new System.EventHandler(this.RoomUnitTextBox_Enter);
            this.RoomUnitTextBox.Leave += new System.EventHandler(this.RoomUnitTextBox_Leave);
            // 
            // RoomUnitLabel
            // 
            this.RoomUnitLabel.AutoSize = true;
            this.RoomUnitLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.RoomUnitLabel.ForeColor = System.Drawing.Color.White;
            this.RoomUnitLabel.Location = new System.Drawing.Point(26, 412);
            this.RoomUnitLabel.Name = "RoomUnitLabel";
            this.RoomUnitLabel.Size = new System.Drawing.Size(68, 15);
            this.RoomUnitLabel.TabIndex = 6;
            this.RoomUnitLabel.Text = "Room Unit";
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CheckOutLabel.ForeColor = System.Drawing.Color.White;
            this.CheckOutLabel.Location = new System.Drawing.Point(264, 473);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(69, 15);
            this.CheckOutLabel.TabIndex = 16;
            this.CheckOutLabel.Text = "Check Out";
            // 
            // SuffixTextBox
            // 
            this.SuffixTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.SuffixTextBox.Location = new System.Drawing.Point(267, 311);
            this.SuffixTextBox.Name = "SuffixTextBox";
            this.SuffixTextBox.Size = new System.Drawing.Size(196, 20);
            this.SuffixTextBox.TabIndex = 13;
            this.SuffixTextBox.Text = "Enter suffix...";
            this.SuffixTextBox.Enter += new System.EventHandler(this.SuffixTextBox_Enter);
            this.SuffixTextBox.Leave += new System.EventHandler(this.SuffixTextBox_Leave);
            // 
            // SuffixLabel
            // 
            this.SuffixLabel.AutoSize = true;
            this.SuffixLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SuffixLabel.ForeColor = System.Drawing.Color.White;
            this.SuffixLabel.Location = new System.Drawing.Point(264, 283);
            this.SuffixLabel.Name = "SuffixLabel";
            this.SuffixLabel.Size = new System.Drawing.Size(41, 15);
            this.SuffixLabel.TabIndex = 12;
            this.SuffixLabel.Text = "Suffix";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.MiddleNameTextBox.Location = new System.Drawing.Point(267, 249);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.MiddleNameTextBox.TabIndex = 11;
            this.MiddleNameTextBox.Text = "Enter middle name...";
            this.MiddleNameTextBox.Enter += new System.EventHandler(this.MiddleNameTextBox_Enter);
            this.MiddleNameTextBox.Leave += new System.EventHandler(this.MiddleNameTextBox_Leave);
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MiddleNameLabel.ForeColor = System.Drawing.Color.White;
            this.MiddleNameLabel.Location = new System.Drawing.Point(264, 221);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(83, 15);
            this.MiddleNameLabel.TabIndex = 10;
            this.MiddleNameLabel.Text = "Middle Name";
            // 
            // CreateRecordButton
            // 
            this.CreateRecordButton.BackColor = System.Drawing.Color.LightGray;
            this.CreateRecordButton.BackgroundColor = System.Drawing.Color.LightGray;
            this.CreateRecordButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateRecordButton.BorderRadius = 20;
            this.CreateRecordButton.BorderSize = 0;
            this.CreateRecordButton.FlatAppearance.BorderSize = 0;
            this.CreateRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRecordButton.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CreateRecordButton.ForeColor = System.Drawing.Color.Black;
            this.CreateRecordButton.Location = new System.Drawing.Point(180, 577);
            this.CreateRecordButton.Name = "CreateRecordButton";
            this.CreateRecordButton.Size = new System.Drawing.Size(125, 34);
            this.CreateRecordButton.TabIndex = 18;
            this.CreateRecordButton.Text = "Create record";
            this.CreateRecordButton.TextColor = System.Drawing.Color.Black;
            this.CreateRecordButton.UseVisualStyleBackColor = false;
            this.CreateRecordButton.Click += new System.EventHandler(this.CreateRecordButton_Click);
            // 
            // CheckInDateTimePicker
            // 
            this.CheckInDateTimePicker.Location = new System.Drawing.Point(29, 501);
            this.CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            this.CheckInDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.CheckInDateTimePicker.TabIndex = 19;
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(267, 501);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.CheckOutDateTimePicker.TabIndex = 20;
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(267, 440);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.TransactionDateTimePicker.TabIndex = 22;
            // 
            // TransactionDateLabel
            // 
            this.TransactionDateLabel.AutoSize = true;
            this.TransactionDateLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TransactionDateLabel.ForeColor = System.Drawing.Color.White;
            this.TransactionDateLabel.Location = new System.Drawing.Point(264, 412);
            this.TransactionDateLabel.Name = "TransactionDateLabel";
            this.TransactionDateLabel.Size = new System.Drawing.Size(106, 15);
            this.TransactionDateLabel.TabIndex = 21;
            this.TransactionDateLabel.Text = "Transaction Date";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ContactLabel.ForeColor = System.Drawing.Color.White;
            this.ContactLabel.Location = new System.Drawing.Point(26, 348);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(101, 15);
            this.ContactLabel.TabIndex = 23;
            this.ContactLabel.Text = "Contact Number";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.ContactTextBox.Location = new System.Drawing.Point(29, 376);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(196, 20);
            this.ContactTextBox.TabIndex = 24;
            this.ContactTextBox.Text = "Enter contact...";
            this.ContactTextBox.Enter += new System.EventHandler(this.ContactCheckBox_Enter);
            this.ContactTextBox.Leave += new System.EventHandler(this.ContactCheckBox_Leave);
            // 
            // CreateReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.TransactionDateTimePicker);
            this.Controls.Add(this.TransactionDateLabel);
            this.Controls.Add(this.CheckOutDateTimePicker);
            this.Controls.Add(this.CheckInDateTimePicker);
            this.Controls.Add(this.CreateRecordButton);
            this.Controls.Add(this.CheckOutLabel);
            this.Controls.Add(this.SuffixTextBox);
            this.Controls.Add(this.SuffixLabel);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.CheckInLabel);
            this.Controls.Add(this.RoomUnitTextBox);
            this.Controls.Add(this.RoomUnitLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.CreateReservationLabel);
            this.Controls.Add(this.LogoPicture);
            this.Name = "CreateReservationPanel";
            this.Size = new System.Drawing.Size(500, 675);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label CreateReservationLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.TextBox RoomUnitTextBox;
        private System.Windows.Forms.Label RoomUnitLabel;
        private System.Windows.Forms.Label CheckOutLabel;
        private System.Windows.Forms.TextBox SuffixTextBox;
        private System.Windows.Forms.Label SuffixLabel;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private Assets.RJButton CreateRecordButton;
        private System.Windows.Forms.DateTimePicker CheckInDateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.Label TransactionDateLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
    }
}
