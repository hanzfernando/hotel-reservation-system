using HotelReservationSystem.Dashboard;
using HotelReservationSystem.Employee;
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
    }

    public interface IPresenterMainWindow : IPresenter
    {
        string Username { get; set; }
    }

    public class PresenterMainWindow : INotifyPropertyChanged, IPresenterMainWindow
    {
        private Form _form;
        private Panel _panel;
        private UserControl _currentPanel;
        private string _userName;

        public string Username { get { return _userName; } set { _userName = value; } }

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

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
