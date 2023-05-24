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
        public DashboardPanel()
        {
            InitializeComponent();
            pictureBox1.Parent = panel1;
            this.TableLayoutNavigationDashboard.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
