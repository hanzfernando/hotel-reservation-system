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
        }
    }
}
