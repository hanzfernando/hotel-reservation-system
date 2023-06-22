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
    public partial class ReservedPanel : UserControl
    {
        private PresenterReservedPanel _presenter;

        public PresenterReservedPanel Presenter { get { return _presenter; } }

        public ReservedPanel()
        {
            InitializeComponent();
            _presenter = new PresenterReservedPanel();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            RoomUnitLabel.Text = "Room Unit " + _presenter.RoomUnit;
            CustomerNameLabel.Text = _presenter.RoomDetail.CustomerName;
            DateLabel.Text = _presenter.RoomDetail.Date;

            label1.Location = new Point((this.panel2.Width / 2) - (label1.Width / 2), (this.panel2.Height / 4) - (label1.Height / 2));
            RoomUnitLabel.Location = new Point((this.panel3.Width / 2) - (RoomUnitLabel.Width / 2), (this.panel3.Height / 2) - (RoomUnitLabel.Height / 2));
            CustomerNameLabel.Location = new Point((this.panel4.Width / 2) - (CustomerNameLabel.Width / 2), (this.panel4.Height / 2) - (CustomerNameLabel.Height / 2));
            DateLabel.Location = new Point((this.panel5.Width / 2) - (DateLabel.Width / 2), (this.panel5.Height / 2) - (DateLabel.Height / 2));

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _presenter.Form.Close();
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            SchedulePanel schedulePanel = new SchedulePanel();
            schedulePanel.Presenter.Form = _presenter.Form;
            schedulePanel.Presenter.Panel = _presenter.Panel;
            schedulePanel.Presenter.RoomUnit = _presenter.RoomUnit;
            schedulePanel.Presenter.PreviousPanel = this;
            _presenter.Panel.Controls.Remove(this);
            _presenter.Panel.Controls.Add(schedulePanel);
        }
    }

    public interface IPresenterReservedPanel : IPresenter
    {
        int RoomUnit { get; set; }
        RoomDetail RoomDetail { get; set; }
    }

    public class PresenterReservedPanel : IPresenterReservedPanel, INotifyPropertyChanged
    {
        private Form _form;
        private Panel _panel;
        private int _roomUnit;
        private RoomDetail _roomDetail;

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
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
