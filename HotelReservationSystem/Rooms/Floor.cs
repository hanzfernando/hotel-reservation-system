using HotelReservationSystem.Constants;
using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Rooms
{
    public partial class Floor : UserControl
    {
        private PresenterFloor _presenter;

        public PresenterFloor Presenter { get { return _presenter; } }
        public Floor()
        {
            InitializeComponent();
            _presenter = new PresenterFloor();
        }

        public void OnLoad (object sender, EventArgs e)
        {
            _presenter.PopulateRoomList();
            _presenter.GetRoomUnit();
            _presenter.GetRoomType();
            UpdateUnitName();
            FloorLabel.Text = "Floor " + _presenter.FloorNumber;
            PeriodicRefresh(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[0].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[0].Status;
            roomDetailsWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[1].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[1].Status;
            roomDetailsWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[2].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[2].Status;
            roomDetailsWindow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[3].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[3].Status;
            roomDetailsWindow.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[4].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[4].Status;
            roomDetailsWindow.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[5].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[5].Status;
            roomDetailsWindow.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[6].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[6].Status;
            roomDetailsWindow.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[7].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[7].Status;
            roomDetailsWindow.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[8].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[8].Status;
            roomDetailsWindow.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[9].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[9].Status;
            roomDetailsWindow.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[10].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[10].Status;
            roomDetailsWindow.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            RoomDetailsWindow roomDetailsWindow = new RoomDetailsWindow();
            roomDetailsWindow.Presenter.FloorNumber = _presenter.FloorNumber;
            roomDetailsWindow.Presenter.RoomUnit = _presenter.RoomStatuses[11].RoomUnit;
            roomDetailsWindow.Presenter.Status = _presenter.RoomStatuses[11].Status;
            roomDetailsWindow.Show();

        }

        public void PeriodicRefresh(object sender, EventArgs e)
        {

            Task periodicTask = RunPeriodicAsynchronousTask(() =>
            {
                _presenter.GetStatus();
                UpdateRooms();
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

        public void UpdateRooms()
        {
            button1.BackColor = _presenter.RoomStatuses[0].Color;
            button2.BackColor = _presenter.RoomStatuses[1].Color;
            button3.BackColor = _presenter.RoomStatuses[2].Color;
            button4.BackColor = _presenter.RoomStatuses[3].Color;
            button5.BackColor = _presenter.RoomStatuses[4].Color;
            button6.BackColor = _presenter.RoomStatuses[5].Color;
            button7.BackColor = _presenter.RoomStatuses[6].Color;
            button8.BackColor = _presenter.RoomStatuses[7].Color;
            button9.BackColor = _presenter.RoomStatuses[8].Color;
            button10.BackColor = _presenter.RoomStatuses[9].Color;
            button11.BackColor = _presenter.RoomStatuses[10].Color;
            button12.BackColor = _presenter.RoomStatuses[11].Color;
        }

        public void UpdateUnitName()
        {
            button1.Text = "Room " + _presenter.RoomStatuses[0].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[0].RoomType;
            button2.Text = "Room " + _presenter.RoomStatuses[1].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[1].RoomType;
            button3.Text = "Room " + _presenter.RoomStatuses[2].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[2].RoomType;
            button4.Text = "Room " + _presenter.RoomStatuses[3].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[3].RoomType;
            button5.Text = "Room " + _presenter.RoomStatuses[4].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[4].RoomType;
            button6.Text = "Room " + _presenter.RoomStatuses[5].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[5].RoomType;
            button7.Text = "Room " + _presenter.RoomStatuses[6].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[6].RoomType;
            button8.Text = "Room " + _presenter.RoomStatuses[7].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[7].RoomType;
            button9.Text = "Room " + _presenter.RoomStatuses[8].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[8].RoomType;
            button10.Text = "Room " + _presenter.RoomStatuses[9].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[9].RoomType;
            button11.Text = "Room " + _presenter.RoomStatuses[10].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[10].RoomType;
            button12.Text = "Room " + _presenter.RoomStatuses[11].RoomUnit.ToString() + "\r\n" + _presenter.RoomStatuses[11].RoomType;

        }

    }
    public interface IPresenterFloor : IPresenter
    {
        RoomStatus[] RoomStatuses { get;}
        int FloorNumber { get; set; }
    }
    public class PresenterFloor : INotifyPropertyChanged, INotifyCollectionChanged, IPresenterFloor
    {
        private Form _form;
        private Panel _panel;
        private int _floorNumber;
        private string _connection = MySqlConstants.Connection;

        private RoomStatus[] _roomStatuses = new RoomStatus[12];


        public Form Form
        {
            get { return _form; }
            set { _form = value; }
        }

        public Panel Panel
        {
            get { return _panel; }
            set { _panel = value; }
        }

        public int FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            } 
        }

        public RoomStatus[] RoomStatuses
        {
            get { return _roomStatuses; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<RoomStatus> RoomStatusesList => new ObservableCollection<RoomStatus>(_roomStatuses);

        public void GetRoomUnit()
        {
            string query = "SELECT * FROM rooms";
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            DataRow[] filteredRows = dataTable.Select("room_floor = " + FloorNumber.ToString());
            
            for (int i = 0; i < filteredRows.Count(); i++)
            {
                _roomStatuses[i].RoomUnit = (int)filteredRows.ElementAt(i)["room_unit"];
            }

        }
        public void GetRoomType()
        {
            string query = "SELECT * FROM rooms, room_types WHERE rooms.room_type_id = room_types.room_type_id";
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);


            DataRow[] filteredRows = dataTable.Select("room_floor = " + FloorNumber.ToString());

            for (int i = 0; i<filteredRows.Count(); i++)
            {
                _roomStatuses[i].RoomType = (string)filteredRows.ElementAt(i)["room_type"];
            }

        }

        public void GetStatus()
        {
            string query = "SELECT * FROM rooms";
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);


            DataRow[] filteredRows = dataTable.Select("room_floor = " + FloorNumber.ToString());

            for (int i = 0; i < filteredRows.Count(); i++)
            {
                RoomStatuses[i].Status = (int)filteredRows.ElementAt(i)["room_status_id"];
            }
        }

        public void PopulateRoomList()
        {
            for (int i =0;  i < _roomStatuses.Length; i++)
            {
                _roomStatuses[i] = new RoomStatus();
            }
        }


    }

    public class RoomStatus : INotifyPropertyChanged
    {
        private int _roomUnit;
        private int _status;
        private string _roomType;
        private int _reservationID;
        private Color _color = Color.FromArgb(215, 89, 210);
        public int Status { get { return _status;} set { _status= value; OnPropertyChanged(nameof(Status));
                GetColor(_status);
            } }

        public Color Color { get { return _color; } set { _color = value; OnPropertyChanged(nameof(Color)); } }

        public int RoomUnit
        {
            get { return _roomUnit; }
            set { _roomUnit = value; OnPropertyChanged(nameof(RoomUnit)); }
        }

        public string RoomType
        {

            get { return _roomType; }
            set { _roomType = value; OnPropertyChanged(nameof(RoomType)); }
        }

        public int ReservationID
        {
            get { return _reservationID; }
            set { _reservationID = value; OnPropertyChanged(nameof(ReservationID)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void GetColor(int i)
        {
            if (i == 0)
            {
                Color = Color.FromArgb(215, 89, 210);
            }
            else if (i == 1)
            {
                Color = Color.FromArgb(167, 100, 252);
            }
            else
            {
                Color = Color.FromArgb(139, 0, 151);
            }
        }
    }

}
