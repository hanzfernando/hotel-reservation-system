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
    public partial class EditReservationPanel : UserControl
    {
        PresenterEditReservationPanel _presenter;

        public PresenterEditReservationPanel Presenter { get { return _presenter; } }

        public EditReservationPanel()
        {
            InitializeComponent();
            _presenter = new PresenterEditReservationPanel();
        }

        private void ReservationIdTextBox_Enter(object sender, EventArgs e)
        {
            if (ReservationIdTextBox.Text == "Enter reservation id...")
            {
                ReservationIdTextBox.Text = "";

                ReservationIdTextBox.ForeColor = Color.Black;
            }
        }

        private void ReservationIdTextBox_Leave(object sender, EventArgs e)
        {
            if (ReservationIdTextBox.Text == "")
            {
                ReservationIdTextBox.Text = "Enter reservation id...";
                ReservationIdTextBox.ForeColor = Color.Silver;
            }
        }

        private void FullNameTextBox_Enter(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == "Enter full name...")
            {
                FullNameTextBox.Text = "";
                
                FullNameTextBox.ForeColor = Color.Black;
            }
                         
        }

        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == "")
            {
                FullNameTextBox.Text = "Enter full name...";
                FullNameTextBox.ForeColor = Color.Silver;
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
                
        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            int prevRoomUnit = _presenter.GetRoomUnit(ReservationIdTextBox.Text);
            string[] strings = { "Reservation id...", "Enter full name...", "Enter room unit..." };


            bool[] inputStatus = new bool[4];

            string checkInDate = CheckInDateTimePicker.Value.ToString("yyyy-MM-dd");
            string checkOutDate = CheckOutDateTimePicker.Value.ToString("yyyy-MM-dd");

            if (ReservationIdTextBox.Text == strings[0] || ReservationIdTextBox.Text == "")
            {
                inputStatus[0] = true;
            }

            if (FullNameTextBox.Text == strings[1] || FullNameTextBox.Text == "")
            {
                inputStatus[1] = true;
            }

            if (RoomUnitTextBox.Text == strings[2] || RoomUnitTextBox.Text == "")
            {
                inputStatus[2] = true;
            }

            if (_presenter.DateAvailability(RoomUnitTextBox.Text, checkInDate, checkOutDate))
            {
                inputStatus[3] = true;
            }          

            string message = "";
            string[] fieldName = { "Reservation Id", "Full Name", "Room Unit","Check-in Date / Check-out Date" };
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
                string transactionDate = TransactionDateTimePicker.Value.ToString("yyyy-MM-dd");
                // string checkInDate = CheckInDateTimePicker.Value.ToString("yyyy-MM-dd");
                // string checkOutDate = CheckOutDateTimePicker.Value.ToString("yyyy-MM-dd");
                
                string query = String.Format(@"UPDATE reservations SET customer_name = '{0}', customer_contact = '{1}', room_unit = {2}, transaction_date = '{3}', check_in = '{4}', check_out = '{5}' WHERE reservation_id = {6}", FullNameTextBox.Text, ContactTextBox.Text, RoomUnitTextBox.Text, transactionDate, checkInDate, checkOutDate, ReservationIdTextBox.Text);

                _presenter.UpdateStatus(query);
                _presenter.UpdateStatus(_presenter.RemovePreviousRoomStatus(prevRoomUnit));
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

    public interface IPresenterEditReservationPanel : IPresenter
    {
        int AdminId { get; set; }

    }

    public class PresenterEditReservationPanel : INotifyPropertyChanged, IPresenterEditReservationPanel
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

        public int GetRoomUnit(string reservationid)
        {
            string query = "SELECT * FROM reservations WHERE reservation_id = " + reservationid;
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            return (int)dataTable.Select().ElementAt(0)["room_unit"];

            
        }

        internal string RemovePreviousRoomStatus(int prevRoomUnit)
        {
            string updateRoomStatus;
            if (HasNextSchedule(prevRoomUnit))
            {
                updateRoomStatus = "UPDATE rooms SET room_status_id = 1 WHERE room_unit = " + prevRoomUnit + "";
            }
            else
            {
                updateRoomStatus = "UPDATE rooms SET room_status_id = 0 WHERE room_unit = " + prevRoomUnit + "";
            }
            return updateRoomStatus;
        }

        private bool HasNextSchedule(int RoomUnit)
        {
            string query = "SELECT * FROM reservations WHERE room_unit = " + RoomUnit + " AND check_out_status = 0 AND reservation_cancel = 0 ORDER BY check_in DESC;";

            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            bool result;

            if (dataTable != null && dataTable.Rows.Count > 1)
            {
                result = true;
            }
            else { result = false; }

            return result;
        }

    }

    
}
