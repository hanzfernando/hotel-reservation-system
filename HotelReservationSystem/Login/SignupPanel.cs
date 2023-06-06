using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.PresenterCommons;

namespace HotelReservationSystem.Login
{
    public partial class SignupPanel : UserControl
    {
        PresenterSignupPanel _presenter;
        //LoginPanel _loginPanel;
        public SignupPanel()
        {
            InitializeComponent();
            _presenter = new PresenterSignupPanel();

            this.HiLabel.Parent = BackgroundPicture2;
            this.SignupLabel.Parent = BackgroundPicture2;

            this.UsernameLabel.Parent = BackgroundPicture2;
            this.EmailLabel.Parent = BackgroundPicture2;
            this.PasswordLabel.Parent = BackgroundPicture2;

            this.ConfirmPasswordLabel.Parent = BackgroundPicture2;

            this.SignInLabel1.Parent = BackgroundPicture2;
            this.SignInLabel2.Parent = BackgroundPicture2;

        }

        public PresenterSignupPanel Presenter { get { return _presenter; } }

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

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "Enter Email...")
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = Color.Black;
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
            {
                EmailTextBox.Text = "Enter Email...";
                EmailTextBox.ForeColor = Color.Silver;
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

        private void ConfimPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (ConfimPasswordTextBox.Text == "Enter Password...")
            {
                ConfimPasswordTextBox.Text = "";
                ConfimPasswordTextBox.ForeColor = Color.Black;
                ConfimPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void ConfimPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfimPasswordTextBox.Text == "")
            {
                ConfimPasswordTextBox.Text = "Enter Password...";
                ConfimPasswordTextBox.ForeColor = Color.Silver;
                ConfimPasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void SignInLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _presenter.Panel.Controls.Remove(this);
            _presenter.Panel.Controls.Add(_presenter.PreviousPanel);
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

        public UserControl PreviousPanel { get { return _previouspanel; } set { _previouspanel = value; } }
        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }
    }
}
