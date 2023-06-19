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
            tableLayoutPanel2.Parent = pictureBox1;
            MonthlyRevenue.Parent = pictureBox2;
            Expected.Parent = pictureBox3;
            ExpectedValue.Parent = pictureBox3;
            Remaining.Parent = pictureBox4;
            RemainingValue.Parent = pictureBox4;
            Collected.Parent = pictureBox5;
            CollectedValue.Parent = pictureBox5;
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
            this.UserName.Text = _presenter.Username;
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
    }
}
