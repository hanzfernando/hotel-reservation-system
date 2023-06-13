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
    public partial class OccupiedPanel : UserControl
    {
        private PresenterOccupiedPanel _presenter;

        public PresenterOccupiedPanel Presenter { get { return _presenter; } }

        public OccupiedPanel()
        {
            InitializeComponent();
            _presenter = new PresenterOccupiedPanel();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            label1.Location = new Point((this.panel2.Width/2)-(label1.Width/2), (this.panel2.Height/4)-(label1.Height/2));
            RoomUnitLabel.Location = new Point((this.panel3.Width / 2) - (RoomUnitLabel.Width / 2), (this.panel3.Height / 2) - (RoomUnitLabel.Height / 2));
            CustomerNameLabel.Location = new Point((this.panel4.Width / 2) - (CustomerNameLabel.Width / 2), (this.panel4.Height / 2) - (CustomerNameLabel.Height / 2));
            DateLabel.Location = new Point((this.panel5.Width / 2) - (DateLabel.Width / 2), (this.panel5.Height / 2) - (DateLabel.Height / 2));
            CloseButton.Location = new Point((this.panel6.Width / 2) - (CloseButton.Width / 2), (this.panel6.Height / 2) - (CloseButton.Height / 2));
            CustomerNameLabel.Text = _presenter.RoomDetail.CustomerName;
            DateLabel.Text = _presenter.RoomDetail.Date;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _presenter.Form.Close();
        }
    }

    public interface IPresenterOccupiedPanel : IPresenter
    {

        RoomDetail RoomDetail { get; set; }
    }

    public class PresenterOccupiedPanel : IPresenterOccupiedPanel, INotifyPropertyChanged
    {
        private Form _form;
        private Panel _panel;
        private RoomDetail _roomDetail;

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }

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
    }
}
