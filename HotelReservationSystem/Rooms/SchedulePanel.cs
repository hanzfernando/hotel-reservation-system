using HotelReservationSystem.Constants;
using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;
using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Rooms
{
    public partial class SchedulePanel : UserControl
    {
        private PresenterSchedulePanel _presenter;

        public PresenterSchedulePanel Presenter { get { return _presenter; } }

        public SchedulePanel()
        {
            InitializeComponent();
            _presenter = new PresenterSchedulePanel();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            CloseButton.Location = new Point((this.panel6.Width / 2) - (CloseButton.Width / 2), (this.panel6.Height / 2) - (CloseButton.Height / 2));
            _presenter.GetSchedule(ScheduleCalendar);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _presenter.Panel.Controls.Remove(this);
            _presenter.Panel.Controls.Add(_presenter.PreviousPanel);
        }
    }

    public interface IPresenterSchedulePanel : IPresenter
    {
        int RoomUnit { get; set; }
        RoomDetail RoomDetail { get; set; }
        UserControl PreviousPanel { get; set; }
    }

    public class PresenterSchedulePanel : IPresenterSchedulePanel, INotifyPropertyChanged
    {
        private Form _form;
        private Panel _panel;
        private int _roomUnit;
        private RoomDetail _roomDetail;
        private UserControl _previousPanel;
        private string _connection = MySqlConstants.Connection;

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }

        public RoomDetail RoomDetail
        {
            get { return _roomDetail; }
            set { _roomDetail = value; OnPropertyChanged(nameof(RoomDetail)); }
        }

        public int RoomUnit
        {
            get { return _roomUnit; }
            set { _roomUnit = value; OnPropertyChanged(nameof(RoomUnit)); }
        }

        public UserControl PreviousPanel
        {
            get { return _previousPanel; }
            set { _previousPanel = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void GetSchedule(Pabo.Calendar.MonthCalendar monthCalendar)
        {
            string query = "SELECT *, (DATEDIFF(check_out, check_in)) AS 'days' FROM reservations WHERE check_in_status = 0 AND check_out_status = 0 AND reservation_cancel = 0 AND room_unit = " + RoomUnit;
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            DataRow[] schedules = dataTable.Select();

            foreach (DataRow schedule in schedules)
            {
                List<DateItem> dates = new List<DateItem>();
                DateTime check_in = (DateTime)schedule["check_in"];
                Debug.Print(check_in.ToString());
                int days = schedule.Field<int>("days");

                for (int i = 0; i < days; i++)
                {
                    DateItem dateItem = new DateItem();
                    dateItem.Date = check_in.AddDays(i);
                    dateItem.BackColor1 = Color.Coral;
                    dateItem.BackColor2 = Color.Coral;
                    dates.Add(dateItem);
                }
                monthCalendar.AddDateInfo(dates.ToArray());

            }
        }
    }
}
