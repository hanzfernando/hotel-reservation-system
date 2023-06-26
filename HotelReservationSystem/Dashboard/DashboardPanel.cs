using Google.Protobuf.WellKnownTypes;
using HotelReservationSystem.Constants;
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
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Globalization;

namespace HotelReservationSystem.Dashboard
{
    public partial class DashboardPanel : UserControl
    {

        private PresenterDashboardPanel _presenter;

        public PresenterDashboardPanel Presenter { get { return _presenter; } }

        public DashboardPanel()
        {
            InitializeComponent();
            _presenter = new PresenterDashboardPanel();
            MonthlyRevenue.Parent = InnerTopPanel;
            CollectedTitleLabel.Parent = InnerBottomPanel;
            CollectedValue.Parent = InnerBottomPanel;
            InnerTopPanel.Parent = OuterPinkPanel;
            InnerBottomPanel.Parent = OuterPinkPanel;
            Floor1.Parent = pictureBox6;
            Floor2.Parent = pictureBox7;
            Floor3.Parent = pictureBox8;
            Floor4.Parent = pictureBox9;
            Floor5.Parent = pictureBox10;
            Floor6.Parent = pictureBox11;
            Floor1Percent.Parent = pictureBox6;
            Floor2Percent.Parent = pictureBox7;
            Floor3Percent.Parent = pictureBox8;
            Floor4Percent.Parent = pictureBox9;
            Floor5Percent.Parent = pictureBox10;
            Floor6Percent.Parent = pictureBox11;
        }
        public void OnLoad (object sender, EventArgs e)
        {
            this.UserName.Text = _presenter.GetName();
            _presenter.GetCollectedMoney();
            CollectedValue.Text = "PHP " + _presenter.Collected;
            PeriodicRefresh(sender, e);
        }

        public void PeriodicRefresh (object sender, EventArgs e)
        {


            Task periodicTask = RunPeriodicAsynchronousTask(() =>
            {
                _presenter.GetAllOccupancyPercentage();
                Floor1Percent.Text = _presenter.Floor1.ToString() + " %";
                Floor2Percent.Text = _presenter.Floor2.ToString() + " %";
                Floor3Percent.Text = _presenter.Floor3.ToString() + " %";
                Floor4Percent.Text = _presenter.Floor4.ToString() + " %";
                Floor5Percent.Text = _presenter.Floor5.ToString() + " %";
                Floor6Percent.Text = _presenter.Floor6.ToString() + " %";
                Floor1Bar.Value = _presenter.Floor1;
                Floor2Bar.Value = _presenter.Floor2;
                Floor3Bar.Value = _presenter.Floor3;
                Floor4Bar.Value = _presenter.Floor4;
                Floor5Bar.Value = _presenter.Floor5;
                Floor6Bar.Value = _presenter.Floor6;
                _presenter.GetCollectedMoney();
                CollectedValue.Text = "PHP " + _presenter.Collected;
            }, TimeSpan.FromSeconds(1));
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public interface IPresenterDashboardPanel : IPresenter
    {
        string Username { get; set; }
        int Floor1 { get; set; }
        int Floor2 { get; set; }
        int Floor3 { get; set; }
        int Floor4 { get; set; }
        int Floor5 { get; set; }
        int Floor6 { get; set; }
        double Collected { get; set; }
        int AdminId { get; set; }
    }

    public class PresenterDashboardPanel : INotifyPropertyChanged, IPresenterDashboardPanel
    {
        private Form _form;
        private Panel _panel;
        private string _username;
        private string _connection = MySqlConstants.Connection;
        private int _floor1 = 0;
        private int _floor2 = 0;
        private int _floor3 = 0;
        private int _floor4 = 0;
        private int _floor5 = 0;
        private int _floor6 = 0;
        private int _adminid;
        private double _collected;

        public event PropertyChangedEventHandler PropertyChanged;
         public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
        }
        public Form Form
        {
            get { return _form; }
            set { _form = value; }
        }
        public Panel Panel { 
            get { return _panel; }
            set { _panel = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public int Floor1
        {
            get { return _floor1; }
            set { _floor1 = value;
                OnPropertyChanged(nameof(Floor1));
            }
        }
        public int Floor2
        {
            get { return _floor2; }
            set { _floor2 = value;
                OnPropertyChanged(nameof(Floor2));
            }
        }
        public int Floor3
        {
            get { return _floor3; }
            set { _floor3 = value;
                OnPropertyChanged(nameof(Floor3));
            }
        }
        public int Floor4
        {
            get { return _floor4; }
            set { _floor4 = value;
                OnPropertyChanged(nameof(Floor4));
            }
        }
        public int Floor5
        {
            get { return _floor5; }
            set { _floor5 = value;
                OnPropertyChanged(nameof(Floor5));
            }
        }
        public int Floor6
        {
            get { return _floor6; }
            set { _floor6 = value;
                OnPropertyChanged(nameof(Floor6));
            }
        }

        public int AdminId { get { return _adminid; } set { _adminid = value; } }

        public double Collected
        {
            get { return _collected; }
            set { _collected = value;
                OnPropertyChanged(nameof(Collected));
            }
        }

        public void Randomize()
        {
            Random random = new Random();
            Floor1 = random.Next(1, 101);
            Floor2 = random.Next(1, 101);
            Floor3 = random.Next(1, 101);
            Floor4 = random.Next(1, 101);
            Floor5 = random.Next(1, 101);
            Floor6 = random.Next(1, 101);
        }

        public int GetOccupancyCount(string floor_number)
        {
            string query = "SELECT * FROM rooms WHERE room_status_id = 2";

            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            DataRow[] filteredRows = dataTable.Select("room_floor = " + floor_number);
            return filteredRows.Length;
        }

        public void GetAllOccupancyPercentage()
        {
            Floor1 = (GetOccupancyCount("1") * 100) / 12;
            Floor2 = (GetOccupancyCount("2") * 100) / 12;
            Floor3 = (GetOccupancyCount("3") * 100) / 12;
            Floor4 = (GetOccupancyCount("4") * 100) / 12;
            Floor5 = (GetOccupancyCount("5") * 100) / 12;
            Floor6 = (GetOccupancyCount("6") * 100) / 12;
        }

        public void GetCollectedMoney()
        {
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            // get all checkin then multiply total cost by 0.9 + get all transactions done then mutiply total cost by 0.1
            string query = String.Format(
                                @"SELECT
                                    COALESCE(
                                        (
                                            SELECT
                                                ROUND(
                                                    SUM(
                                                        IF(
                                                            MONTH(r.check_in) = 6 AND YEAR(r.check_in) = 2023,
                                                            (DATEDIFF(r.check_out, r.check_in) * rtp.room_rate) * 0.9,
                                                            0
                                                        )
                                                    )
                                                ,2) AS totalCost
                                            FROM
                                                reservations r
                                                JOIN rooms rms ON r.room_unit = rms.room_unit
                                                JOIN room_types rtp ON rms.room_type_id = rtp.room_type_id
                                            WHERE
                                                MONTH(check_in) = 6 AND YEAR(check_in) = 2023
                                                #AND r.reservation_status = ""Checked In"" OR r.reservation_status = ""Checked Out""
                                                AND r.check_in_status = 1
                                        ),
                                        0
                                    )

                                    +

                                    (
                                        SELECT
                                            ROUND(
                                                SUM(
                                                    IF(
                                                        MONTH(r.transaction_date) = 6 AND YEAR(r.transaction_date) = 2023,
                                                        (DATEDIFF(r.check_out, r.check_in) * rtp.room_rate) * 0.1,
                                                        0
                                                    )
                                                )
                                            ,2) AS totalCost
                                        FROM
                                            reservations r
                                            JOIN rooms rms ON r.room_unit = rms.room_unit
                                            JOIN room_types rtp ON rms.room_type_id = rtp.room_type_id
                                        WHERE
                                            MONTH(r.transaction_date) = 6 AND YEAR(r.transaction_date) = 2023
                                    )
                                 AS ""CollectedMoney""", currentMonth, currentYear);
            string _connection = Constants.MySqlConstants.Connection;
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);
            //Collected = (double)dt.Select().ElementAt(0)["CollectedMoney"];
            try
            {
                Collected = (double)dt.Select().ElementAt(0)["CollectedMoney"];
            }
            catch (Exception ex) 
            {
                Collected = 0;
            }
            


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
