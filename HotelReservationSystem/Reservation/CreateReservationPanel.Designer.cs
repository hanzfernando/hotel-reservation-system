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
            this.CheckInTextBox = new System.Windows.Forms.TextBox();
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.RoomUnitTextBox = new System.Windows.Forms.TextBox();
            this.RoomUnitLabel = new System.Windows.Forms.Label();
            this.CheckOutTextBox = new System.Windows.Forms.TextBox();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.PaymentMethodTextBox = new System.Windows.Forms.TextBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.SuffixTextBox = new System.Windows.Forms.TextBox();
            this.SuffixLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.CreateRecordButton = new HotelReservationSystem.Assets.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(0, 59);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(500, 95);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // CreateReservationLabel
            // 
            this.CreateReservationLabel.AutoSize = true;
            this.CreateReservationLabel.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CreateReservationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.CreateReservationLabel.Location = new System.Drawing.Point(142, 157);
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
            this.LastNameTextBox.Location = new System.Drawing.Point(29, 324);
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
            this.LastNameLabel.Location = new System.Drawing.Point(26, 296);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(70, 15);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // CheckInTextBox
            // 
            this.CheckInTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.CheckInTextBox.Location = new System.Drawing.Point(29, 479);
            this.CheckInTextBox.Name = "CheckInTextBox";
            this.CheckInTextBox.Size = new System.Drawing.Size(196, 20);
            this.CheckInTextBox.TabIndex = 9;
            this.CheckInTextBox.Text = "Enter check in date...";
            this.CheckInTextBox.Enter += new System.EventHandler(this.CheckInTextBox_Enter);
            this.CheckInTextBox.Leave += new System.EventHandler(this.CheckInTextBox_Leave);
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CheckInLabel.ForeColor = System.Drawing.Color.White;
            this.CheckInLabel.Location = new System.Drawing.Point(26, 451);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(59, 15);
            this.CheckInLabel.TabIndex = 8;
            this.CheckInLabel.Text = "Check In";
            // 
            // RoomUnitTextBox
            // 
            this.RoomUnitTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.RoomUnitTextBox.Location = new System.Drawing.Point(29, 400);
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
            this.RoomUnitLabel.Location = new System.Drawing.Point(26, 372);
            this.RoomUnitLabel.Name = "RoomUnitLabel";
            this.RoomUnitLabel.Size = new System.Drawing.Size(68, 15);
            this.RoomUnitLabel.TabIndex = 6;
            this.RoomUnitLabel.Text = "Room Unit";
            // 
            // CheckOutTextBox
            // 
            this.CheckOutTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.CheckOutTextBox.Location = new System.Drawing.Point(267, 479);
            this.CheckOutTextBox.Name = "CheckOutTextBox";
            this.CheckOutTextBox.Size = new System.Drawing.Size(196, 20);
            this.CheckOutTextBox.TabIndex = 17;
            this.CheckOutTextBox.Text = "Enter check out date...";
            this.CheckOutTextBox.Enter += new System.EventHandler(this.CheckOutTextBox_Enter);
            this.CheckOutTextBox.Leave += new System.EventHandler(this.CheckOutTextBox_Leave);
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CheckOutLabel.ForeColor = System.Drawing.Color.White;
            this.CheckOutLabel.Location = new System.Drawing.Point(264, 451);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(69, 15);
            this.CheckOutLabel.TabIndex = 16;
            this.CheckOutLabel.Text = "Check Out";
            // 
            // PaymentMethodTextBox
            // 
            this.PaymentMethodTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.PaymentMethodTextBox.Location = new System.Drawing.Point(267, 400);
            this.PaymentMethodTextBox.Name = "PaymentMethodTextBox";
            this.PaymentMethodTextBox.Size = new System.Drawing.Size(196, 20);
            this.PaymentMethodTextBox.TabIndex = 15;
            this.PaymentMethodTextBox.Text = "Enter payment method...";
            this.PaymentMethodTextBox.Enter += new System.EventHandler(this.PaymentMethodTextBox_Enter);
            this.PaymentMethodTextBox.Leave += new System.EventHandler(this.PaymentMethodTextBox_Leave);
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PaymentMethodLabel.ForeColor = System.Drawing.Color.White;
            this.PaymentMethodLabel.Location = new System.Drawing.Point(264, 372);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(106, 15);
            this.PaymentMethodLabel.TabIndex = 14;
            this.PaymentMethodLabel.Text = "Payment Method";
            // 
            // SuffixTextBox
            // 
            this.SuffixTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.SuffixTextBox.Location = new System.Drawing.Point(267, 324);
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
            this.SuffixLabel.Location = new System.Drawing.Point(264, 296);
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
            this.CreateRecordButton.Location = new System.Drawing.Point(180, 559);
            this.CreateRecordButton.Name = "CreateRecordButton";
            this.CreateRecordButton.Size = new System.Drawing.Size(125, 34);
            this.CreateRecordButton.TabIndex = 18;
            this.CreateRecordButton.Text = "Create record";
            this.CreateRecordButton.TextColor = System.Drawing.Color.Black;
            this.CreateRecordButton.UseVisualStyleBackColor = false;
            this.CreateRecordButton.Click += new System.EventHandler(this.CreateRecordButton_Click);
            // 
            // CreateReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.CreateRecordButton);
            this.Controls.Add(this.CheckOutTextBox);
            this.Controls.Add(this.CheckOutLabel);
            this.Controls.Add(this.PaymentMethodTextBox);
            this.Controls.Add(this.PaymentMethodLabel);
            this.Controls.Add(this.SuffixTextBox);
            this.Controls.Add(this.SuffixLabel);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.CheckInTextBox);
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
        private System.Windows.Forms.TextBox CheckInTextBox;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.TextBox RoomUnitTextBox;
        private System.Windows.Forms.Label RoomUnitLabel;
        private System.Windows.Forms.TextBox CheckOutTextBox;
        private System.Windows.Forms.Label CheckOutLabel;
        private System.Windows.Forms.TextBox PaymentMethodTextBox;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.TextBox SuffixTextBox;
        private System.Windows.Forms.Label SuffixLabel;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private Assets.RJButton CreateRecordButton;
    }
}
