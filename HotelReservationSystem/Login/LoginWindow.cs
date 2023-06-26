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

namespace HotelReservationSystem.Login
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Presenter.Form = this;
            loginPanel.Presenter.Panel = this.loginPanel;
            this.loginPanel.Controls.Add(loginPanel);
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
          
        }
    }
}
