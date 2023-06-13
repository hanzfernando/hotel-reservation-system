using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Assets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Diagnostics;

//using HotelReservationSystem.MainWindow;

namespace HotelReservationSystem.Login
{
    public partial class LoginPanel : UserControl
    {
        PresenterLoginPanel _presenter;
  
        public LoginPanel()
        {
            InitializeComponent();
            _presenter = new PresenterLoginPanel();


            this.WelcomeLabel.Parent = BackgroundPicture1;
            this.SigninLabel.Parent = BackgroundPicture1;

            this.UsernameLabel.Parent = BackgroundPicture1;

            this.PasswordLabel.Parent = BackgroundPicture1;

            this.ShowPasswordCheckBox.Parent = BackgroundPicture1;

            this.CreateLabel.Parent = BackgroundPicture1;
            this.CreateLinkLabel.Parent = BackgroundPicture1;



        }

        public PresenterLoginPanel Presenter { get { return _presenter; } }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Enter Username...")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = "Enter Username...";
                UsernameTextBox.ForeColor = Color.Silver;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Enter Password...")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Enter Password...";
                PasswordTextBox.ForeColor = Color.Silver;
                PasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void CreateLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupPanel signupPanel = new SignupPanel();
            signupPanel.Presenter.Panel = this._presenter.Panel;
            signupPanel.Presenter.Form = this._presenter.Form;
            signupPanel.Presenter.PreviousPanel = this;
            _presenter.Panel.Controls.Remove(this);
            _presenter.Panel.Controls.Add(signupPanel);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _presenter.Username = UsernameTextBox.Text;
            _presenter.Password = PasswordTextBox.Text;

            if(_presenter.ValidateLogIn())
            {
                HotelReservationSystem.MainWindow.MainWindow mainWindow = new HotelReservationSystem.MainWindow.MainWindow();
                mainWindow.Presenter.Username = _presenter.Username;
                mainWindow.Presenter.AdminId = _presenter.GetId();

                this._presenter.Form.Hide();
                mainWindow.Closed += (s, args) => this._presenter.Form.Close();
                mainWindow.Show();
            }
            else
            {
                // pop up window if wrong
            }
        }
    }

    public interface IPresenterLoginPanel : IPresenter
    {
        string Username { get; set; }
        string Password { set; }
    }

    public class PresenterLoginPanel : INotifyPropertyChanged, IPresenterLoginPanel
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        private Form _form;
        private Panel _panel;
        private string _username;
        private string _password;
        private string _connection = Constants.MySqlConstants.Connection;

        public string Username { get { return _username; } set { _username = value; } }
        public string Password { set { _password = value; } }

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }

        public Boolean ValidateLogIn()
        {
            string query = "SELECT * FROM admins WHERE admin_username LIKE '" + _username + "' AND admin_password LIKE '" + _password + "'";
            MySqlConnection mySqlConnection = new MySqlConnection(_connection);
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader mySqlDataReader;
            mySqlConnection.Open();
            mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            /*MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            MySqlDataAdapter.*/
            
        }

        public int GetId()
        {
            string query = "SELECT admin_id FROM admins WHERE admin_username LIKE '" + _username + "' AND admin_password LIKE '" + _password + "'";
            MySqlConnection mySqlConnection = new MySqlConnection(_connection);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);                      
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0]; 
            int adminId = Convert.ToInt32(row["admin_id"]);
            
            return adminId;
        }
    }
}
