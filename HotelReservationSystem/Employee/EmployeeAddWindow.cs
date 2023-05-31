using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Employee
{
    public partial class EmployeeAddWindow : Form
    {
        private PresenterEmployeeAddWindow _presenter;

        public PresenterEmployeeAddWindow Presenter { get { return _presenter; } }

        public EmployeeAddWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
            _presenter = new PresenterEmployeeAddWindow();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.AddEmployee(AdminUsernameBox.Text, AdminPasswordBox.Text);
            this.Close();
            _presenter.Parent.RefreshGridView(_presenter.Parent, e);
        }
    }

    public interface IPresenterEmployeeAddWindow : IPresenter
    {

    }

    public class PresenterEmployeeAddWindow : INotifyPropertyChanged, IPresenterEmployeeAddWindow
    {
        private EmployeePanel _parent;
        private Form _form;
        private Panel _panel;
        private string _connection = Constants.MySqlConstants.Connection;

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

        public EmployeePanel Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        public void AddEmployee(string adminUsername, string adminPassword)
        {
            string query = "insert into admin (admin_username, admin_password) values('" + adminUsername + "','" + adminPassword + "')";
            MySqlConnection mySqlConnection = new MySqlConnection(_connection);
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader mySqlDataReader;
            mySqlConnection.Open();
            mySqlCommand.ExecuteReader();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
