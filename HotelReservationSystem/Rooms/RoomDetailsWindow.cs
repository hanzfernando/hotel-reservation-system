using HotelReservationSystem.PresenterCommons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            OccupiedPanel occupied = new OccupiedPanel();
            occupied.Presenter.Form = this;
            occupied.Presenter.Panel = panel1;
            this.panel1.Controls.Add(occupied);
        }
    }

    public interface IPresenterRoomDetailsWindow : IPresenter
    {
        int FloorNumber { get; set; }
        int RoomUnit { get; set; }

    }

    public class PresenterRoomDetailsWindow : INotifyPropertyChanged, IPresenterRoomDetailsWindow
    {
        private Form _form;
        private Panel _panel;
        private int _floorNumber;
        private int _roomUnit;

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

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
