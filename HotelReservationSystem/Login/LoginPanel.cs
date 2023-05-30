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


            this.WelcomeLabel.Parent = BackgroundPicture;
            this.SigninLabel.Parent = BackgroundPicture;

            this.UsernameLabel.Parent = BackgroundPicture;

            this.PasswordLabel.Parent = BackgroundPicture;

            this.ShowPasswordCheckBox.Parent = BackgroundPicture;

            this.CreateLabel.Parent = BackgroundPicture;
            this.CreateLinkLabel.Parent = BackgroundPicture;



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

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _presenter.Username = UsernameTextBox.Text;
            _presenter.Password = PasswordTextBox.Text;

            if(_presenter.ValidateLogIn())
            {
                HotelReservationSystem.MainWindow.MainWindow mainWindow = new HotelReservationSystem.MainWindow.MainWindow();
                /*this._presenter.Form.Hide();
                mainWindow.Show();*/

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
        string Username { set; }
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
        private string _connection = "server=localhost;port=3307;username=root;password=;database=hotel_reservation_system";

        public string Username { set { _username = value; } }
        public string Password { set { _password = value; } }

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }

        public Boolean ValidateLogIn()
        {
            string query = "SELECT * FROM admin WHERE admin_username LIKE '" + _username + "' AND admin_password LIKE '" + _password + "'";
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
    }
}
