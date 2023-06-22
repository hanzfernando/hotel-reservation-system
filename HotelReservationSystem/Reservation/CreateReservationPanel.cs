using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Reservation
{
    public partial class CreateReservationPanel : UserControl
    {
        PresenterCreateReservationPanel _presenter;

        public PresenterCreateReservationPanel Presenter { get { return _presenter; } }

        public CreateReservationPanel()
        {
            InitializeComponent();
            _presenter = new PresenterCreateReservationPanel();
        }

        public void OnLoad (object sender, EventArgs e)
        {
            Username.Text = _presenter.GetName();
            Username.Location = new Point((this.Width / 2) - (Username.Width / 2), Username.Location.Y);
        }

        private void FirstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "Enter first name...")
            {
                FirstNameTextBox.Text = "";
                
                FirstNameTextBox.ForeColor = Color.Black;
            }                        
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "")
            {
                FirstNameTextBox.Text = "Enter first name...";
                FirstNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void MiddleNameTextBox_Enter(object sender, EventArgs e)
        {
            if (MiddleNameTextBox.Text == "Enter middle name...")
            {
                MiddleNameTextBox.Text = "";
                MiddleNameTextBox.ForeColor = Color.Black;
            }
        }

        private void MiddleNameTextBox_Leave(object sender, EventArgs e)
        {
            if (MiddleNameTextBox.Text == "")
            {
                MiddleNameTextBox.Text = "Enter middle name...";
                MiddleNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void LastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text == "Enter last name...")
            {
                LastNameTextBox.Text = "";
                LastNameTextBox.ForeColor = Color.Black;
            }
        }

        private void LastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text == "")
            {
                LastNameTextBox.Text = "Enter last name...";
                LastNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void SuffixTextBox_Enter(object sender, EventArgs e)
        {
            if (SuffixTextBox.Text == "Enter suffix...")
            {
                SuffixTextBox.Text = "";
                SuffixTextBox.ForeColor = Color.Black;
            }
        }

        private void SuffixTextBox_Leave(object sender, EventArgs e)
        {
            if (SuffixTextBox.Text == "")
            {
                SuffixTextBox.Text = "Enter suffix...";
                SuffixTextBox.ForeColor = Color.Silver;
            }
        }

        private void ContactCheckBox_Enter(object sender, EventArgs e)
        {
            if (ContactTextBox.Text == "Enter contact...")
            {
                ContactTextBox.Text = "";
                ContactTextBox.ForeColor = Color.Black;
            }
        }

        private void ContactCheckBox_Leave(object sender, EventArgs e)
        {
            if (ContactTextBox.Text == "")
            {
                ContactTextBox.Text = "Enter contact...";
                ContactTextBox.ForeColor = Color.Silver;
            }
        }

        private void RoomUnitTextBox_Enter(object sender, EventArgs e)
        {
            if (RoomUnitTextBox.Text == "Enter room unit...")
            {
                RoomUnitTextBox.Text = "";
                RoomUnitTextBox.ForeColor = Color.Black;
            }
        }

        private void RoomUnitTextBox_Leave(object sender, EventArgs e)
        {
            if (RoomUnitTextBox.Text == "")
            {
                RoomUnitTextBox.Text = "Enter room unit...";
                RoomUnitTextBox.ForeColor = Color.Silver;
            }
        }
                
        private void CreateRecordButton_Click(object sender, EventArgs e)
        {
            string[] strings = { "Enter first name...", "Enter last name...", "Enter room unit..." };
            bool[] inputStatus = new bool[4];

            if (FirstNameTextBox.Text == strings[0] || FirstNameTextBox.Text == "")
            {
                inputStatus[0] = true;
            }

            if (LastNameTextBox.Text == strings[1] || LastNameTextBox.Text == "")
            {
                inputStatus[1] = true;
            }

            if (RoomUnitTextBox.Text == strings[2] || RoomUnitTextBox.Text == "")
            {
                inputStatus[2] = true;
            }

            string checkInDate = CheckInDateTimePicker.Value.ToString("yyyy-MM-dd");
            string checkOutDate = CheckOutDateTimePicker.Value.ToString("yyyy-MM-dd");


            if (_presenter.DateAvailability(RoomUnitTextBox.Text, checkInDate, checkOutDate))
            {
                inputStatus[3] = true;
            }          

            string message = "";
            string[] fieldName = { "First Name", "Last Name", "Room Unit", "Check-in Date / Check-out Date" };
            bool isError = false;

            for (int i = 0; i < inputStatus.Length; i++)
            {
                if (inputStatus[i])
                {
                    message += "Invalid Input on " + fieldName[i] + Environment.NewLine;
                    isError = true;
                }
            }
                      
            if(isError)
            {
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string middleName;
                string suffix;

                if (MiddleNameTextBox.Text == "Enter middle name...")
                {
                    middleName = " ";
                }else
                {
                    middleName = " " + MiddleNameTextBox.Text + " ";
                }

                if (SuffixTextBox.Text == "Enter suffix...")
                {
                    suffix = "";
                }
                else
                {
                    suffix = " " + SuffixTextBox.Text;
                }

                string transactionDate = TransactionDateTimePicker.Value.ToString("yyyy-MM-dd");
                // string checkInDate = CheckInDateTimePicker.Value.ToString("yyyy-MM-dd");
                // string checkOutDate = CheckOutDateTimePicker.Value.ToString("yyyy-MM-dd");
                
                string query = "INSERT INTO reservations (admin_id, room_unit, transaction_date, customer_name, customer_contact, check_in, check_out, reservation_status) " +
                    "VALUES ('" + _presenter.AdminId + "', " +
                    RoomUnitTextBox.Text + ", " +
                    "'" + transactionDate + "', " +
                    "'" + FirstNameTextBox.Text + middleName + LastNameTextBox.Text + suffix + "', " +
                    "'" + ContactTextBox.Text + "', " +
                    "'" + checkInDate + "', " +
                    "'" + checkOutDate + "', " +
                    "'Reserved');";

                _presenter.UpdateStatus(query);
                _presenter.UpdateStatus(_presenter.RoomStatusQuery(RoomUnitTextBox.Text.Trim()));
                // Close
                _presenter.Form.Close();

                /*if (_presenter.CheckRoomStatus(RoomUnitTextBox.Text.Trim()))
                {
                    //string updateRoomStatus = "UPDATE rooms SET room_status_id = 1 WHERE room_unit = " + RoomUnitTextBox.Text + "";
                    //_presenter.UpdateStatus(query);
                    //_presenter.UpdateStatus(updateRoomStatus);
                    // Close
                    //.Form.Close();
                }
                else
                {

                    string caption = "";
                    if (_presenter.GetRoomStatusId(RoomUnitTextBox.Text.Trim()) == 0)
                    {
                        return;
                    }
                    else if(_presenter.GetRoomStatusId(RoomUnitTextBox.Text.Trim()) == 1)
                    {
                        caption = "Room Already Reserved";
                    }
                    else if (_presenter.GetRoomStatusId(RoomUnitTextBox.Text.Trim()) == 2)
                    {
                        caption = "Room Already Occupied";
                    }
                    else
                    {
                        caption = "Invalid Status";
                    }

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }     */        
                
            }
        }
    }

    public interface IPresenterCreateReservationPanel : IPresenter
    {
        int AdminId { get; set; }

    }

    public class PresenterCreateReservationPanel : INotifyPropertyChanged, IPresenterCreateReservationPanel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        private Form _form;
        private Panel _panel;
        private int _adminid;
        
        private static string _connection = Constants.MySqlConstants.Connection;


        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }
        public int AdminId { get { return _adminid; } set { _adminid = value; } }
        
        public void UpdateStatus(string query)
        {
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();

        }

        public bool CheckRoomStatus(string roomUnit)
        {
            string query = "SELECT * FROM rooms WHERE room_unit = " + roomUnit + " AND room_status_id = 0";
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            return mySqlDataReader.HasRows;
        }

        public int GetRoomStatusId(string roomUnit)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT * FROM rooms WHERE room_unit = " + roomUnit;
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            mySqlDataAdapter.Fill(dataTable);
            return (int)dataTable.Select().ElementAt(0)["room_status_id"];
           
        }

        public bool DateAvailability(string roomUnit, string checkIn, string checkOut)
        {
            string query = "SELECT * FROM reservations WHERE room_unit = " + roomUnit + " AND (check_in <= '" + checkOut + "' AND check_out >= '" + checkIn + "') AND reservation_status NOT LIKE 'Cancelled';";
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            return mySqlDataReader.HasRows;
        }

        public string RoomStatusQuery(string RoomUnit)
        {
            string updateRoomStatus;
            if (IsRoomOccupied(RoomUnit))
            {
                updateRoomStatus = "UPDATE rooms SET room_status_id = 2 WHERE room_unit = " + RoomUnit + "";
            }
            else
            {
                updateRoomStatus = "UPDATE rooms SET room_status_id = 1 WHERE room_unit = " + RoomUnit + "";
            }
            return updateRoomStatus;

        }

        private bool IsRoomOccupied(string RoomUnit)
        {
            string query = "SELECT * FROM rooms WHERE room_unit = " + RoomUnit + " AND room_status_id = 2";

            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            bool result;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                result = true;
            }
            else { result = false; }

            Debug.WriteLine(result);

            return result;
        }

        public string GetName()
        {
            string query = "SELECT * FROM admins WHERE admin_id = " + AdminId;
            MySqlConnection mySqlConnection = new MySqlConnection(_connection);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0];
            string fname = Convert.ToString(row["admin_fname"]);
            string lname = Convert.ToString(row["admin_lname"]);

            return fname + " " + lname;
        }
    }

    
}
