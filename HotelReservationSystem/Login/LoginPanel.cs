using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Login
{
    public partial class LoginPanel : UserControl
    {
        Panel panel;
        Form form;

        public LoginPanel(Panel panel, Form form)
        {
            InitializeComponent();
            this.panel = panel;
            this.form = form;

            this.TitleLabel.Parent = BackgroundPicture;
            //this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Parent = BackgroundPicture;
            //this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Parent = BackgroundPicture;
            //this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameTextbox.Parent = BackgroundPicture;
            this.PasswordTextbox.Parent = BackgroundPicture;

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
