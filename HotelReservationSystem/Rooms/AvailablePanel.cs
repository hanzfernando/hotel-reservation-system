using HotelReservationSystem.PresenterCommons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Rooms
{
    public partial class AvailablePanel : UserControl
    {
        private PresenterAvailablePanel _presenter;
        public PresenterAvailablePanel Presenter { get { return _presenter; } }
        public AvailablePanel()
        {
            InitializeComponent();
            _presenter = new PresenterAvailablePanel();
        }

        private void OnLoad (object sender, EventArgs e)
        {
            label1.Location = new Point((this.panel2.Width / 2) - (label1.Width / 2), (this.panel2.Height / 4) - (label1.Height / 2));
            pictureBox1.Location = new Point((this.panel3.Width / 2) - (pictureBox1.Width / 2), (this.panel3.Height / 2) - (pictureBox1.Height / 2));
            CloseButton.Location = new Point((this.panel4.Width / 2) - (CloseButton.Width / 2), (this.panel4.Height / 2) - (CloseButton.Height / 2));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _presenter.Form.Close();
        }
    }

    public interface IPresenterAvailablePanel : IPresenter
    {

    }

    public class PresenterAvailablePanel : INotifyPropertyChanged, IPresenterAvailablePanel
    {
        private Form _form;
        private Panel _panel;
        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
