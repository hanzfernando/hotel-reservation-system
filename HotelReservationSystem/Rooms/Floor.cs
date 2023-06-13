using HotelReservationSystem.PresenterCommons;
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
            FloorLabel.Text = "Floor " + _presenter.FloorNumber;
            PeriodicRefresh(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

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

        public void GetStatus()
        {
            Random random = new Random();
            for (int i = 0; i < RoomStatuses.Length; i++)
            {
                RoomStatuses[i].Status = random.Next(0,3);
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
        private int _status;
        private Color _color = Color.FromArgb(215, 89, 210);
        public int Status { get { return _status;} set { _status= value; OnPropertyChanged(nameof(Status));
                GetColor(_status);
            } }

        public Color Color { get { return _color; } set { _color = value; OnPropertyChanged(nameof(Color)); } }

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
