using HotelReservationSystem.Dashboard;
using HotelReservationSystem.PresenterCommons;
using HotelReservationSystem.Reservation;
using HotelReservationSystem.Rooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.MainWindow
{
    public partial class MainWindow : Form
    {
        private PresenterMainWindow _presenter;
        public PresenterMainWindow Presenter { get { return _presenter; } }
        public MainWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
            _presenter = new PresenterMainWindow();
            _presenter.Form = this;
            _presenter.Panel = PanelRoot;
        }
        public void OnLoad (object sender, EventArgs e)
        {
            DashboardPanel dashboard = new DashboardPanel();
            dashboard.Presenter.Form = _presenter.Form;
            dashboard.Presenter.Panel = _presenter.Panel;
            dashboard.Presenter.Username = _presenter.Username;
            PanelRoot.Controls.Add(dashboard);
            _presenter.CurrentPanel = dashboard;
        }

        private void DashboardTab_Click(object sender, EventArgs e)
        {
            _presenter.Width = 1200;
            this.Width = _presenter.Width;
            this.CenterToScreen();
            DashboardPanel dashboardPanel = new DashboardPanel();
            dashboardPanel.Presenter.Username = _presenter.Username;
            if (!dashboardPanel.Equals(_presenter.CurrentPanel))
            {
                dashboardPanel.Presenter.Form = _presenter.Form;
                dashboardPanel.Presenter.Panel = _presenter.Panel;
                _presenter.Panel.Controls.Remove(_presenter.CurrentPanel);
                _presenter.Panel.Controls.Add(dashboardPanel);
                _presenter.CurrentPanel = dashboardPanel;
            }
        }

        private void ReservationTab_Click(object sender, EventArgs e)
        {
            _presenter.Width = 1600;
            this.Width = _presenter.Width;
            this.CenterToScreen();
            ReservationPanel reservationPanel = new ReservationPanel();
            if (!reservationPanel.Equals(_presenter.CurrentPanel))
            {
                reservationPanel.Presenter.AdminId = _presenter.AdminId;
                reservationPanel.Presenter.Form = _presenter.Form;
                reservationPanel.Presenter.Panel = _presenter.Panel;
                _presenter.Panel.Controls.Remove(_presenter.CurrentPanel);
                _presenter.Panel.Controls.Add(reservationPanel);
                _presenter.CurrentPanel = reservationPanel;
            }

        }

        private void RoomsTab_Click(object sender, EventArgs e)
        {
            _presenter.Width = 1200;
            this.Width = _presenter.Width;
            this.CenterToScreen();
            RoomsPanel roomsPanel = new RoomsPanel();
            if(!roomsPanel.Equals(_presenter.CurrentPanel))
            {
                roomsPanel.Presenter.Form = _presenter.Form;
                roomsPanel.Presenter.Panel = _presenter.Panel;
                _presenter.Panel.Controls.Remove(_presenter.CurrentPanel);
                _presenter.Panel.Controls.Add(roomsPanel);
                _presenter.CurrentPanel = roomsPanel;
            }
        }
    }

    public interface IPresenterMainWindow : IPresenter
    {
        string Username { get; set; }
        int AdminId { get; set; }
        int Width { get; set; }  
    }

    public class PresenterMainWindow : INotifyPropertyChanged, IPresenterMainWindow
    {
        private Form _form;
        private Panel _panel;
        private UserControl _currentPanel;
        private string _userName;
        private int _adminid;
        private int _width;

        public string Username { get { return _userName; } set { _userName = value; } }
        public int AdminId { get { return _adminid; } set { _adminid = value; } }

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

        public UserControl CurrentPanel
        {
            get { return _currentPanel; }
            set { _currentPanel = value; } 
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
