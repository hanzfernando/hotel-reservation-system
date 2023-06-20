namespace HotelReservationSystem.Reservation
{
    partial class EditReservationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReservationPanel));
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.CreateReservationLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.RoomUnitTextBox = new System.Windows.Forms.TextBox();
            this.RoomUnitLabel = new System.Windows.Forms.Label();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.EditRecordButton = new HotelReservationSystem.Assets.RJButton();
            this.CheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDateLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.ReservationIdTextBox = new System.Windows.Forms.TextBox();
            this.ReservationIdLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
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
            this.CreateReservationLabel.Location = new System.Drawing.Point(144, 129);
            this.CreateReservationLabel.Name = "CreateReservationLabel";
            this.CreateReservationLabel.Size = new System.Drawing.Size(238, 25);
            this.CreateReservationLabel.TabIndex = 1;
            this.CreateReservationLabel.Text = "Reservation Edited By";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.White;
            this.FirstNameLabel.Location = new System.Drawing.Point(264, 221);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(66, 15);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "Full Name";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.FullNameTextBox.Location = new System.Drawing.Point(267, 249);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.Text = "Enter full name...";
            this.FullNameTextBox.Enter += new System.EventHandler(this.FullNameTextBox_Enter);
            this.FullNameTextBox.Leave += new System.EventHandler(this.FullNameTextBox_Leave);
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CheckInLabel.ForeColor = System.Drawing.Color.White;
            this.CheckInLabel.Location = new System.Drawing.Point(26, 470);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(59, 15);
            this.CheckInLabel.TabIndex = 8;
            this.CheckInLabel.Text = "Check In";
            // 
            // RoomUnitTextBox
            // 
            this.RoomUnitTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.RoomUnitTextBox.Location = new System.Drawing.Point(29, 410);
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
            this.RoomUnitLabel.Location = new System.Drawing.Point(26, 382);
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
            this.CheckOutLabel.Location = new System.Drawing.Point(264, 470);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(69, 15);
            this.CheckOutLabel.TabIndex = 16;
            this.CheckOutLabel.Text = "Check Out";
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.BackColor = System.Drawing.Color.LightGray;
            this.EditRecordButton.BackgroundColor = System.Drawing.Color.LightGray;
            this.EditRecordButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EditRecordButton.BorderRadius = 20;
            this.EditRecordButton.BorderSize = 0;
            this.EditRecordButton.FlatAppearance.BorderSize = 0;
            this.EditRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRecordButton.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EditRecordButton.ForeColor = System.Drawing.Color.Black;
            this.EditRecordButton.Location = new System.Drawing.Point(180, 577);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(125, 34);
            this.EditRecordButton.TabIndex = 18;
            this.EditRecordButton.Text = "Confirm";
            this.EditRecordButton.TextColor = System.Drawing.Color.Black;
            this.EditRecordButton.UseVisualStyleBackColor = false;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // CheckInDateTimePicker
            // 
            this.CheckInDateTimePicker.Location = new System.Drawing.Point(29, 498);
            this.CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            this.CheckInDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.CheckInDateTimePicker.TabIndex = 19;
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(267, 498);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.CheckOutDateTimePicker.TabIndex = 20;
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(267, 410);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.TransactionDateTimePicker.TabIndex = 22;
            // 
            // TransactionDateLabel
            // 
            this.TransactionDateLabel.AutoSize = true;
            this.TransactionDateLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TransactionDateLabel.ForeColor = System.Drawing.Color.White;
            this.TransactionDateLabel.Location = new System.Drawing.Point(264, 382);
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
            this.ContactLabel.Location = new System.Drawing.Point(26, 301);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(101, 15);
            this.ContactLabel.TabIndex = 23;
            this.ContactLabel.Text = "Contact Number";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.ContactTextBox.Location = new System.Drawing.Point(29, 329);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(196, 20);
            this.ContactTextBox.TabIndex = 24;
            this.ContactTextBox.Text = "Enter contact...";
            this.ContactTextBox.Enter += new System.EventHandler(this.ContactCheckBox_Enter);
            this.ContactTextBox.Leave += new System.EventHandler(this.ContactCheckBox_Leave);
            // 
            // ReservationIdTextBox
            // 
            this.ReservationIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.ReservationIdTextBox.Location = new System.Drawing.Point(29, 249);
            this.ReservationIdTextBox.Name = "ReservationIdTextBox";
            this.ReservationIdTextBox.Size = new System.Drawing.Size(196, 20);
            this.ReservationIdTextBox.TabIndex = 26;
            this.ReservationIdTextBox.Text = "Enter reservation id...";
            this.ReservationIdTextBox.Enter += new System.EventHandler(this.ReservationIdTextBox_Enter);
            this.ReservationIdTextBox.Leave += new System.EventHandler(this.ReservationIdTextBox_Leave);
            // 
            // ReservationIdLabel
            // 
            this.ReservationIdLabel.AutoSize = true;
            this.ReservationIdLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ReservationIdLabel.ForeColor = System.Drawing.Color.White;
            this.ReservationIdLabel.Location = new System.Drawing.Point(26, 221);
            this.ReservationIdLabel.Name = "ReservationIdLabel";
            this.ReservationIdLabel.Size = new System.Drawing.Size(93, 15);
            this.ReservationIdLabel.TabIndex = 25;
            this.ReservationIdLabel.Text = "Reservation ID";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(189, 170);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(101, 19);
            this.Username.TabIndex = 27;
            this.Username.Text = "<Username>";
            // 
            // EditReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ReservationIdTextBox);
            this.Controls.Add(this.ReservationIdLabel);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.TransactionDateTimePicker);
            this.Controls.Add(this.TransactionDateLabel);
            this.Controls.Add(this.CheckOutDateTimePicker);
            this.Controls.Add(this.CheckInDateTimePicker);
            this.Controls.Add(this.EditRecordButton);
            this.Controls.Add(this.CheckOutLabel);
            this.Controls.Add(this.CheckInLabel);
            this.Controls.Add(this.RoomUnitTextBox);
            this.Controls.Add(this.RoomUnitLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.CreateReservationLabel);
            this.Controls.Add(this.LogoPicture);
            this.Name = "EditReservationPanel";
            this.Size = new System.Drawing.Size(500, 675);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label CreateReservationLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.TextBox RoomUnitTextBox;
        private System.Windows.Forms.Label RoomUnitLabel;
        private System.Windows.Forms.Label CheckOutLabel;
        private Assets.RJButton EditRecordButton;
        private System.Windows.Forms.DateTimePicker CheckInDateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.Label TransactionDateLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox ReservationIdTextBox;
        private System.Windows.Forms.Label ReservationIdLabel;
        private System.Windows.Forms.Label Username;
    }
}
