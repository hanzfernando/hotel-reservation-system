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
            tableLayoutPanel2.Parent = pictureBox1;
            MonthlyRevenue.Parent = pictureBox2;
            Expected.Parent = pictureBox3;
            ExpectedValue.Parent = pictureBox3;
            Remaining.Parent = pictureBox4;
            RemainingValue.Parent = pictureBox4;
            Collected.Parent = pictureBox5;
            CollectedValue.Parent = pictureBox5;
            Floor1.Parent = pictureBox6;
            Floor2.Parent = pictureBox7;
            Floor3.Parent = pictureBox8;
            Floor4.Parent = pictureBox9;
            Floor5.Parent = pictureBox10;
            Floor6.Parent = pictureBox11;
            Floor1Percent.Parent = pictureBox6;
            Floor2Percent.Parent = pictureBox7;
            Floor3Percent.Parent = pictureBox8;
            Floor4Percent.Parent = pictureBox9;
            Floor5Percent.Parent = pictureBox10;
            Floor6Percent.Parent = pictureBox11;
        }
        public void OnLoad (object sender, EventArgs e)
        {
            this.UserName.Text = _presenter.Username;
        }
    }

    public interface IPresenterDashboardPanel : IPresenter
    {
        string Username { get; set; }
    }

    public class PresenterDashboardPanel : INotifyPropertyChanged, IPresenterDashboardPanel
    {
        private Form _form;
        private Panel _panel;
        private string _username;

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
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
    }
}
