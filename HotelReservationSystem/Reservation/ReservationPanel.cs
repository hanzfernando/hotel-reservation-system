using HotelReservationSystem.Login;
using HotelReservationSystem.MainWindow;
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

namespace HotelReservationSystem.Reservation
{
    public partial class ReservationPanel : UserControl
    {
        PresenterReservationPanel _presenter;
        public ReservationPanel()
        {
            InitializeComponent();
            _presenter = new PresenterReservationPanel();
        }

        private void ReservationLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public PresenterReservationPanel Presenter { get { return _presenter; } }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            HotelReservationSystem.Reservation.ReservationWindow reservationWindow = new ReservationWindow();
            reservationWindow.Show();
        }
    }

    public interface IPresenterReservationPanel : IPresenter
    {

    }

    public class PresenterReservationPanel : INotifyPropertyChanged, IPresenterReservationPanel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        private Form _form;
        private Panel _panel;

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }
    }
}
