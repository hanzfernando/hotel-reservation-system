using HotelReservationSystem.Constants;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Rooms
{
    public partial class RoomDetailsWindow : Form
    {

        private PresenterRoomDetailsWindow _presenter;

        public PresenterRoomDetailsWindow Presenter { get { return _presenter; } }
        public RoomDetailsWindow()
        {
            InitializeComponent();
            _presenter = new PresenterRoomDetailsWindow();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.CenterToScreen();
            switch (_presenter.Status)
            {
                case 0:
                    AvailablePanel available = new AvailablePanel();
                    available.Presenter.Form = this;
                    available.Presenter.Panel = panel1;
                    this.panel1.Controls.Add(available);
                    break;
                case 1:
                    _presenter.GetRoomDetail();
                    ReservedPanel reserved = new ReservedPanel();
                    reserved.Presenter.Form = this;
                    reserved.Presenter.Panel = panel1;
                    reserved.Presenter.RoomUnit = _presenter.RoomUnit;
                    reserved.Presenter.RoomDetail = _presenter.RoomDetail;
                    this.panel1.Controls.Add(reserved);
                    break; 
                case 2:
                    _presenter.GetRoomDetail();
                    OccupiedPanel occupied = new OccupiedPanel();
                    occupied.Presenter.Form = this;
                    occupied.Presenter.Panel = panel1;
                    occupied.Presenter.RoomUnit = _presenter.RoomUnit;
                    occupied.Presenter.RoomDetail = _presenter.RoomDetail;
                    this.panel1.Controls.Add(occupied);
                    break;
                default:
                    break;
            }
        }
    }

    public interface IPresenterRoomDetailsWindow : IPresenter
    {
        int FloorNumber { get; set; }
        int RoomUnit { get; set; }
        int Status { get; set; }
        RoomDetail RoomDetail { get; set; }

    }

    public class PresenterRoomDetailsWindow : INotifyPropertyChanged, IPresenterRoomDetailsWindow
    {
        private Form _form;
        private Panel _panel;
        private int _floorNumber;
        private int _roomUnit;
        private int _status;
        private string _connection = MySqlConstants.Connection;
        private RoomDetail _roomDetail = new RoomDetail();

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }

        public int FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value; OnPropertyChanged(nameof(FloorNumber)); }
        }
        public int RoomUnit
        {
            get { return _roomUnit; }
            set { _roomUnit = value; OnPropertyChanged(nameof(RoomUnit)); }
        }
        public int Status
        {
            get { return _status; }
            set { _status = value; OnPropertyChanged(nameof(RoomStatus)); }
        }
        public RoomDetail RoomDetail
        {
            get { return _roomDetail; }
            set { _roomDetail = value; OnPropertyChanged(nameof(RoomDetail)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public void GetRoomDetail()
        {

            string query = "SELECT * FROM reservations WHERE room_unit = "+RoomUnit;
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);

            DataRow filteredRow = dataTable.Rows[dataTable.Rows.Count-1];

            RoomDetail.CustomerName = (string)filteredRow["customer_name"];
            RoomDetail.Date = ((DateTime)filteredRow["check_in"]).ToString();
        }
    }

    public class RoomDetail : INotifyPropertyChanged
    {
        private string _customerName;
        private string _date;

        public string CustomerName { get { return _customerName; } set { _customerName = value; OnPropertyChanged(nameof(CustomerName)); } }
        public string Date { get { return _date; } set { _date = value; OnPropertyChanged(nameof(Date)); } }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
