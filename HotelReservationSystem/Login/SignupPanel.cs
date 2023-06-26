using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem.Login
{
    public partial class SignupPanel : UserControl
    {
        PresenterSignupPanel _presenter;
        public SignupPanel()
        {
            InitializeComponent();
            _presenter = new PresenterSignupPanel();

            this.HiLabel.Parent = BackgroundPicture2;
            this.SignupLabel.Parent = BackgroundPicture2;

            this.UsernameLabel.Parent = BackgroundPicture2;
            this.FirstNameLabel.Parent = BackgroundPicture2;
            this.PasswordLabel.Parent = BackgroundPicture2;

            this.ConfirmPasswordLabel.Parent = BackgroundPicture2;

            this.SignInLabel1.Parent = BackgroundPicture2;
            this.SignInLabel2.Parent = BackgroundPicture2;

        }

        public PresenterSignupPanel Presenter { get { return _presenter; } }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Enter username...")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = "Enter username...";
                UsernameTextBox.ForeColor = Color.Silver;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Enter password...")
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
                PasswordTextBox.Text = "Enter password...";
                PasswordTextBox.ForeColor = Color.Silver;
                PasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void ConfimPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.Text == "Confirm password...")
            {
                ConfirmPasswordTextBox.Text = "";
                ConfirmPasswordTextBox.ForeColor = Color.Black;
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void ConfimPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.Text == "")
            {
                ConfirmPasswordTextBox.Text = "Confirm password...";
                ConfirmPasswordTextBox.ForeColor = Color.Silver;
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void FirstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "Enter first name...")
            {
                FirstNameTextBox.Text = "";
                FirstNameTextBox.ForeColor = Color.Black;
                
            }
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "")
            {
                FirstNameTextBox.Text = "Enter first name...";
                FirstNameTextBox.ForeColor = Color.Silver;
               
            }
        }

        private void LastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text == "Enter last name...")
            {
                LastNameTextBox.Text = "";
                LastNameTextBox.ForeColor = Color.Black;
               
            }
        }

        private void LastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text == "")
            {
                LastNameTextBox.Text = "Enter last name...";
                LastNameTextBox.ForeColor = Color.Silver;
                
            }
        }

        private void SignInLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _presenter.Panel.Controls.Remove(this);
            _presenter.Panel.Controls.Add(_presenter.PreviousPanel);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string[] strings = { "Enter first name...", "Enter last name...", "Enter username...","Enter password...", "Confirm password..." };
            bool[] inputStatus = new bool[5];

            if (FirstNameTextBox.Text == strings[0] || FirstNameTextBox.Text == "")
            {
                inputStatus[0] = true;
            }

            if (LastNameTextBox.Text == strings[1] || LastNameTextBox.Text == "")
            {
                inputStatus[1] = true;
            }

            if (UsernameTextBox.Text == strings[2] || UsernameTextBox.Text == "")
            {
                inputStatus[2] = true;
            }

            if (PasswordTextBox.Text == strings[3] || PasswordTextBox.Text == "" || ConfirmPasswordTextBox.Text == strings[4] || ConfirmPasswordTextBox.Text == "" || PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                inputStatus[3] = true;
            }

            

            string message = "";
            string[] fieldName = { "First Name", "Last Name", "Username", "Passwords"};
            bool isError = false;

            for (int i = 0; i < inputStatus.Length; i++)
            {
                if (inputStatus[i])
                {
                    message += "Invalid Input on " + fieldName[i] + Environment.NewLine;
                    isError = true;
                }
                
            }

            if(isError)
            {
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string query = "INSERT INTO admins (admin_username, admin_password, admin_fname, admin_lname) " +
                    String.Format(@"VALUES ( '{0}', '{1}', '{2}', '{3}')", UsernameTextBox.Text, PasswordTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text);
                _presenter.AddData(query);

                _presenter.Panel.Controls.Remove(this);
                _presenter.Panel.Controls.Add(_presenter.PreviousPanel);
            }

        }
    }

    public interface IPresenterSignupPanel : IPresenter
    {
        UserControl PreviousPanel { get; set; }
        string Username { set; }
        string Email { set; }
        string Password { set; }
        string ConfirmPassword { set; }
    }

    public class PresenterSignupPanel : INotifyPropertyChanged, IPresenterSignupPanel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Form _form;
        private Panel _panel;
        private UserControl _previouspanel;
        private string _username;
        private string _email;
        private string _password;
        private string _confirmpassword;

        public string Username { set { _username = value; } }
        public string Email { set { _email = value; } }
        public string Password { set { _password = value; } }
        public string ConfirmPassword { set { _confirmpassword = value; } }
        private static string _connection = Constants.MySqlConstants.Connection;

        public UserControl PreviousPanel { get { return _previouspanel; } set { _previouspanel = value; } }
        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }


        public void AddData(string query)
        {
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();

        }
    }


}
