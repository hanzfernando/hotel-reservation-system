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
        }
    }

    public interface IPresenterDashboardPanel : IPresenter
    {

    }

    public class PresenterDashboardPanel : INotifyPropertyChanged, IPresenterDashboardPanel
    {
        private Form _form;
        private Panel _panel;

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
    }
}
