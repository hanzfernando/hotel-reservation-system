using HotelReservationSystem.Login;
using HotelReservationSystem.MainWindow;
using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
                _presenter.PopulateDataTable(ReservationDataGridView);
                _presenter.AdjustTableWidth(ReservationDataGridView);

            }, TimeSpan.FromSeconds(3));
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

        private void ReservationPanel_Load(object sender, EventArgs e)
        {
            _presenter.PopulateDataTable(ReservationDataGridView);
            
            PeriodicRefresh(sender, e);
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

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }
        public int AdminId { get { return _adminid; } set { _adminid = value; } }

        private static string _connection = Constants.MySqlConstants.Connection;

        

        public void PopulateDataTable(DataGridView dataGridView)
        {

            string query = "SELECT " +
                "reservation_id AS 'Reservation ID', " +
                "room_unit AS 'Room Unit', " +
                "transaction_date AS 'Transaction Date', " +
                "customer_name AS 'Customer Name', " +
                "check_in AS 'Check In', " +
                "check_in_status AS 'Check-in Status', " +
                "check_out AS 'Check Out', " +
                "check_out_status AS 'Check-out Status', " +
                "reservation_status AS 'Status' " + 
                "FROM reservations";

            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;

            // Adjust the header text
            dataGridView.Columns["Reservation ID"].HeaderText = "Reservation ID";
            dataGridView.Columns["Room Unit"].HeaderText = "Room Unit";
            dataGridView.Columns["Transaction Date"].HeaderText = "Transaction Date";
            dataGridView.Columns["Customer Name"].HeaderText = "Customer Name";
            dataGridView.Columns["Check In"].HeaderText = "Check In";
            dataGridView.Columns["Check-in Status"].HeaderText = "Check-in Status";
            dataGridView.Columns["Check Out"].HeaderText = "Check Out";
            dataGridView.Columns["Check-out Status"].HeaderText = "Check-out Status";
            dataGridView.Columns["Status"].HeaderText = "Status";

            // Adjust the cell alignment
            dataGridView.Columns["Reservation ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Room Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Transaction Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Customer Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check In"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check-in Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check Out"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Check-out Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            _datatable = dataTable;
        }

        public void AdjustTableWidth(DataGridView dataGridView)
        {
            // Set the Dock property to Fill
            dataGridView.Dock = DockStyle.Fill;

            // Set the AutoSizeMode property to None for each column
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            // Calculate the total width of all columns
            int totalColumnWidth = dataGridView.Width;

            // Calculate the width for each column
            int columnWidth = totalColumnWidth / _datatable.Columns.Count;

            // Set the width of each column
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = columnWidth;
            }
        }
    }
}

