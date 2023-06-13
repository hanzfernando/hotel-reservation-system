using HotelReservationSystem.Login;
using HotelReservationSystem.MainWindow;
using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelReservationSystem.Reservation
{
    public partial class ReservationPanel : UserControl
    {
        PresenterReservationPanel _presenter;
        public ReservationPanel()
        {
            InitializeComponent();
            _presenter = new PresenterReservationPanel();
            
        }

        public PresenterReservationPanel Presenter { get { return _presenter; } }

        private void CreateButton_Click(object sender, EventArgs e)
        {

            HotelReservationSystem.Reservation.CreateReservationWindow reservationWindow = new CreateReservationWindow();
            reservationWindow.Presenter.AdminId = _presenter.AdminId;

            reservationWindow.Show();
            
        }

        public void PeriodicRefresh(object sender, EventArgs e)
        {

            Task periodicTask = RunPeriodicAsynchronousTask(() =>
            {
                _presenter.RowIndex = ReservationDataGridView.CurrentRow.Index;
                _presenter.PopulateDataTable(ReservationDataGridView);
                ReservationDataGridView.CurrentCell = ReservationDataGridView.Rows[_presenter.RowIndex].Cells[0];

            }, TimeSpan.FromMilliseconds(2000));
        }

        public async Task RunPeriodicAsynchronousTask(Action action, TimeSpan interval)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            try
            {
                while (!token.IsCancellationRequested)
                {
                    action.Invoke();
                    await Task.Delay(interval, token);
                }
            }
            catch (TaskCanceledException)
            {
                // Task was cancelled
            }
        }

        public void ReservationPanel_Load(object sender, EventArgs e)
        {
            
            _presenter.PopulateDataTable(ReservationDataGridView);
            ReservationDataGridView.CellContentClick += ReservationDataGridView_CellContentClick;

            PeriodicRefresh(sender, e);
        }

        public void ReservationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the clicked column is the "Check-in Status" column
            if (e.ColumnIndex == ReservationDataGridView.Columns["Check-in Status"].Index && e.RowIndex >= 0)
            {
                // Get the current cell
                DataGridViewCheckBoxCell cellIn = ReservationDataGridView.Rows[e.RowIndex].Cells["Check-in Status"] as DataGridViewCheckBoxCell;

                // Check if the corresponding "Check-out Status" is currently true
                bool checkOutStatus = (bool)ReservationDataGridView.Rows[e.RowIndex].Cells["Check-out Status"].Value;
                
                // Check if the corresponding "Cancellation" is currently true
                bool cancelStatus = (bool)ReservationDataGridView.Rows[e.RowIndex].Cells["Cancellation"].Value;

                if (checkOutStatus || cancelStatus)
                {
                    // Disable checkbox click for "Check-in Status"
                    cellIn.ReadOnly = true;
                    return;
                }

                // Toggle the checkbox value
                cellIn.Value = !(bool)cellIn.Value;
                
                string query;
                string updateRoom;
                if ((bool)cellIn.Value == true)
                {
                    query = "UPDATE reservations SET check_in_status = " + cellIn.Value + ", reservation_status = 'Checked In' WHERE reservation_id = " + _presenter.ReservationList.ElementAt(e.RowIndex).ReservationId;
                    updateRoom = "UPDATE rooms SET room_status_id = 2 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;

                }
                else
                {
                    query = "UPDATE reservations SET check_in_status = " + cellIn.Value + ", reservation_status = 'Reserved' WHERE reservation_id = " + _presenter.ReservationList.ElementAt(e.RowIndex).ReservationId;
                    updateRoom = "UPDATE rooms SET room_status_id = 1 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;
                }



                _presenter.UpdateStatus(query);
                _presenter.UpdateStatus(updateRoom);
                // ReservationDataGridView.Refresh();
            }

            // Check out
            if (e.ColumnIndex == ReservationDataGridView.Columns["Check-out Status"].Index && e.RowIndex >= 0)
            {
                // Get the current cell
                DataGridViewCheckBoxCell cellOut = ReservationDataGridView.Rows[e.RowIndex].Cells["Check-out Status"] as DataGridViewCheckBoxCell;

                // Check if the corresponding "Check-out Status" is currently true
                bool checkInStatus = (bool)ReservationDataGridView.Rows[e.RowIndex].Cells["Check-in Status"].Value;
                // Check if the corresponding "Cancellation" is currently true
                bool cancelStatus = (bool)ReservationDataGridView.Rows[e.RowIndex].Cells["Cancellation"].Value;

                if (!checkInStatus || cancelStatus)
                {
                    // Disable checkbox click for "Check-in Status"
                    cellOut.ReadOnly = true;
                    return;
                }
                // Toggle the checkbox value
                cellOut.Value = !(bool)cellOut.Value;


                // Commit the change to the underlying data source
                string query;
                string updateRoom;
                if ((bool)cellOut.Value == true)
                {
                    query = "UPDATE reservations SET check_out_status = " + cellOut.Value + ", reservation_status = 'Checked Out' WHERE reservation_id = " + _presenter.ReservationList.ElementAt(e.RowIndex).ReservationId;
                    updateRoom = "UPDATE rooms SET room_status_id = 0 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;
                }
                else                   
                {
                    query = "UPDATE reservations SET check_out_status = " + cellOut.Value + ", reservation_status = 'Checked In' WHERE reservation_id = " + _presenter.ReservationList.ElementAt(e.RowIndex).ReservationId;
                    updateRoom = "UPDATE rooms SET room_status_id = 1 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;
                }

                _presenter.UpdateStatus(query);
                _presenter.UpdateStatus(updateRoom);
                // ReservationDataGridView.Refresh();
            }
            // Cancel
            if (e.ColumnIndex == ReservationDataGridView.Columns["Cancellation"].Index && e.RowIndex >= 0)
            {
                // Get the current cell
                DataGridViewCheckBoxCell cellCancel = ReservationDataGridView.Rows[e.RowIndex].Cells["Cancellation"] as DataGridViewCheckBoxCell;

                // Check if the corresponding "Check-out Status" is currently true
                bool checkInStatus = (bool)ReservationDataGridView.Rows[e.RowIndex].Cells["Check-in Status"].Value;
                // Check if the corresponding "Check-out Status" is currently true
                bool checkOutStatus = (bool)ReservationDataGridView.Rows[e.RowIndex].Cells["Check-out Status"].Value;
                // Toggle the checkbox value
                cellCancel.Value = !(bool)cellCancel.Value;
                
                // Commit the change to the underlying data source

                string query;
                string updateRoom;
                if ((bool)cellCancel.Value == true)
                {
                    query = "UPDATE reservations SET reservation_cancel = " + cellCancel.Value + ", reservation_status = 'Cancelled' WHERE reservation_id = " + _presenter.ReservationList.ElementAt(e.RowIndex).ReservationId;
                    updateRoom = "UPDATE rooms SET room_status_id = 0 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;
                }
                else
                {
                    query = "UPDATE reservations SET reservation_cancel = " + cellCancel.Value + ", reservation_status = 'Checked Out' WHERE reservation_id = " + _presenter.ReservationList.ElementAt(e.RowIndex).ReservationId;
                    if (!checkInStatus && !checkOutStatus)
                    {
                        updateRoom = "UPDATE rooms SET room_status_id = 1 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;
                    }
                    else if (checkInStatus && !checkOutStatus)
                    {
                        updateRoom = "UPDATE rooms SET room_status_id = 2 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;
                    }
                    else if (checkInStatus && checkOutStatus)
                    {
                        updateRoom = "UPDATE rooms SET room_status_id = 0 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;
                    }
                    else
                    {
                        updateRoom = "UPDATE rooms SET room_status_id = 0 WHERE room_unit = " + _presenter.ReservationList.ElementAt(e.RowIndex).RoomUnit;
                    }
                }

                _presenter.UpdateStatus(query);
                _presenter.UpdateStatus(updateRoom);
                // ReservationDataGridView.Refresh();
            }


        }

    }

    public interface IPresenterReservationPanel : IPresenter
    {
        int AdminId { get; set; }
    }

    public class PresenterReservationPanel : INotifyPropertyChanged, IPresenterReservationPanel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        private Form _form;
        private Panel _panel;
        private int _adminid;
        private DataTable _datatable = new DataTable();
        private List<Reservation> _reservationlist = new List<Reservation>();
        private int _rowIndex;

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }
        public int AdminId { get { return _adminid; } set { _adminid = value; } }
        public int RowIndex { get { return _rowIndex; } set { _rowIndex = value; } }

        private static string _connection = Constants.MySqlConstants.Connection;
                

        public List<Reservation> ReservationList { get { return _reservationlist; } }

        public void UpdateStatus(string query)
        {
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
                      
        }

        public void PopulateDataTable(DataGridView dataGridView)
        {

            string query = "SELECT " +
                "r.reservation_id AS 'Reservation ID', " +
                "r.room_unit AS 'Room Unit', " +
                "r.transaction_date AS 'Transaction Date', " +
                "r.customer_name AS 'Customer Name', " +
                "r.customer_name AS 'Contact', " +
                "r.check_in AS 'Check In', " +
                "r.check_in_status AS 'Check-in Status', " +
                "r.check_out AS 'Check Out', " +
                "r.check_out_status AS 'Check-out Status', " +
                "r.reservation_cancel AS 'Cancellation', " +              
                "rtp.room_rate AS 'Daily Cost', " + 
                "(DATEDIFF(r.check_out, r.check_in)) AS 'Days', " +
                "(DATEDIFF(r.check_out, r.check_in) * rtp.room_rate) AS 'Total Cost', " +
                "r.reservation_status AS 'Status' " +
                "FROM reservations r " +
                "JOIN rooms rms " +
                    "ON r.room_unit = rms.room_unit " + 
                "JOIN room_types rtp " +
                    "ON rms.room_type_id = rtp.room_type_id";

            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;

            // Adjust the header text
            /*dataGridView.Columns["Reservation ID"].HeaderText = "Reservation ID";
            dataGridView.Columns["Room Unit"].HeaderText = "Room Unit";
            dataGridView.Columns["Transaction Date"].HeaderText = "Transaction Date";
            dataGridView.Columns["Customer Name"].HeaderText = "Customer Name";
            dataGridView.Columns["Check In"].HeaderText = "Check In";
            dataGridView.Columns["Check-in Status"].HeaderText = "Check-in Status";
            dataGridView.Columns["Check Out"].HeaderText = "Check Out";
            dataGridView.Columns["Check-out Status"].HeaderText = "Check-out Status";
            dataGridView.Columns["Status"].HeaderText = "Status";*/

            // Set Width
            dataGridView.Columns["Reservation ID"].Width = 100;
            dataGridView.Columns["Room Unit"].Width = 75;
            dataGridView.Columns["Transaction Date"].Width = 100;
            dataGridView.Columns["Customer Name"].Width = 125;
            dataGridView.Columns["Contact"].Width = 100;
            dataGridView.Columns["Check In"].Width = 100;
            dataGridView.Columns["Check-in Status"].Width = 75;
            dataGridView.Columns["Check Out"].Width = 100;
            dataGridView.Columns["Check-out Status"].Width = 75;
            dataGridView.Columns["Cancellation"].Width = 100;
            dataGridView.Columns["Daily Cost"].Width = 75;
            dataGridView.Columns["Days"].Width = 50;
            dataGridView.Columns["Total Cost"].Width = 75;
            dataGridView.Columns["Status"].Width = 75;

            // Adjust the cell alignment
            dataGridView.Columns["Reservation ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Room Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Transaction Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Customer Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Contact"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check In"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check-in Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check Out"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check-out Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Cancellation"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Daily Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Days"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Total Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Update the data type and appearance of the checkbox column
            dataTable.Columns["Check-in Status"].DataType = typeof(bool);
            dataGridView.Columns["Check-in Status"].DefaultCellStyle.NullValue = false;
            dataGridView.Columns["Check-in Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check-in Status"].CellTemplate = new DataGridViewCheckBoxCell();
            // Set the column to be clickable
            dataGridView.Columns["Check-in Status"].ReadOnly = false;

            // Update the data type and appearance of the checkbox column
            dataTable.Columns["Check-out Status"].DataType = typeof(bool);
            dataGridView.Columns["Check-out Status"].DefaultCellStyle.NullValue = false;
            dataGridView.Columns["Check-out Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check-out Status"].CellTemplate = new DataGridViewCheckBoxCell();
            // Set the column to be clickable
            dataGridView.Columns["Check-out Status"].ReadOnly = true;

            // Update the data type and appearance of the checkbox column
            dataTable.Columns["Cancellation"].DataType = typeof(bool);
            dataGridView.Columns["Cancellation"].DefaultCellStyle.NullValue = false;
            dataGridView.Columns["Cancellation"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Cancellation"].CellTemplate = new DataGridViewCheckBoxCell();
            // Set the column to be clickable
            dataGridView.Columns["Cancellation"].ReadOnly = false;



            _datatable = dataTable;

            DataRow[] dataRows = dataTable.Select();
            foreach (DataRow row in dataRows)
            {
                Reservation reservation = new Reservation();
                reservation.ReservationId = (int)row["Reservation ID"];
                reservation.RoomUnit = (int)row["Room Unit"];
                _reservationlist.Add(reservation);
            }
            
        }
     
    }

    public class Reservation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        private int _reservation_id;
        private int _roomunit;
        private bool _check_in_status;
        private bool _check_out_status;
        private bool _cancellation;

        public int ReservationId { get { return _reservation_id; } set { _reservation_id = value; } }
        public int RoomUnit { get { return _roomunit; } set { _roomunit = value; } }

        public bool Check_In_Status { get { return _check_in_status; } set { _check_in_status = value; } }
        public bool Check_Out_Status { get { return _check_out_status; } set { _check_out_status = value; } }
        public bool Cancellation { get { return _cancellation; } set { _cancellation = value; } }
    }
}

