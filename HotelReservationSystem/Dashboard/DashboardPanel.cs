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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardPanel_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
