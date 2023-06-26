using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Threading;
using Org.BouncyCastle.Crypto.Modes.Gcm;

namespace HotelReservationSystem.Login
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void  LoginWindow_Load(object sender, EventArgs e)
        {
            SplashScreenPanel splashScreen = new SplashScreenPanel();
            this.loginPanel.Controls.Add(splashScreen);
            await Task.Delay(3000);
            this.loginPanel.Controls.Remove(splashScreen);
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Presenter.Form = this;
            loginPanel.Presenter.Panel = this.loginPanel;
            this.loginPanel.Controls.Add(loginPanel);
        }
    }
}
