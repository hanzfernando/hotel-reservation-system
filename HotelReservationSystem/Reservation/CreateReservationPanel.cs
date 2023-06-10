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
    public partial class CreateReservationPanel : UserControl
    {
        PresenterCreateReservationPanel _presenter;

        public PresenterCreateReservationPanel Presenter { get { return _presenter; } }

        public CreateReservationPanel()
        {
            InitializeComponent();
            _presenter = new PresenterCreateReservationPanel();
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

        private void MiddleNameTextBox_Enter(object sender, EventArgs e)
        {
            if (MiddleNameTextBox.Text == "Enter middle name...")
            {
                MiddleNameTextBox.Text = "";
                MiddleNameTextBox.ForeColor = Color.Black;
            }
        }

        private void MiddleNameTextBox_Leave(object sender, EventArgs e)
        {
            if (MiddleNameTextBox.Text == "")
            {
                MiddleNameTextBox.Text = "Enter middle name...";
                MiddleNameTextBox.ForeColor = Color.Silver;
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

        private void SuffixTextBox_Enter(object sender, EventArgs e)
        {
            if (SuffixTextBox.Text == "Enter suffix...")
            {
                SuffixTextBox.Text = "";
                SuffixTextBox.ForeColor = Color.Black;
            }
        }

        private void SuffixTextBox_Leave(object sender, EventArgs e)
        {
            if (SuffixTextBox.Text == "")
            {
                SuffixTextBox.Text = "Enter suffix...";
                SuffixTextBox.ForeColor = Color.Silver;
            }
        }

        private void RoomUnitTextBox_Enter(object sender, EventArgs e)
        {
            if (RoomUnitTextBox.Text == "Enter room unit...")
            {
                RoomUnitTextBox.Text = "";
                RoomUnitTextBox.ForeColor = Color.Black;
            }
        }

        private void RoomUnitTextBox_Leave(object sender, EventArgs e)
        {
            if (RoomUnitTextBox.Text == "")
            {
                RoomUnitTextBox.Text = "Enter room unit...";
                RoomUnitTextBox.ForeColor = Color.Silver;
            }
        }

        private void PaymentMethodTextBox_Enter(object sender, EventArgs e)
        {
            if (PaymentMethodTextBox.Text == "Enter payment method...")
            {
                PaymentMethodTextBox.Text = "";
                PaymentMethodTextBox.ForeColor = Color.Black;
            }
        }

        private void PaymentMethodTextBox_Leave(object sender, EventArgs e)
        {
            if (PaymentMethodTextBox.Text == "")
            {
                PaymentMethodTextBox.Text = "Enter payment method...";
                PaymentMethodTextBox.ForeColor = Color.Silver;
            }
        }

        private void CheckInTextBox_Enter(object sender, EventArgs e)
        {
            if (CheckInTextBox.Text == "Enter check in date...")
            {
                CheckInTextBox.Text = "";
                CheckInTextBox.ForeColor = Color.Black;
            }
        }

        private void CheckInTextBox_Leave(object sender, EventArgs e)
        {
            if (CheckInTextBox.Text == "")
            {
                CheckInTextBox.Text = "Enter check in date...";
                CheckInTextBox.ForeColor = Color.Silver;
            }
        }

        private void CheckOutTextBox_Enter(object sender, EventArgs e)
        {
            if (CheckOutTextBox.Text == "Enter check out date...")
            {
                CheckOutTextBox.Text = "";
                CheckOutTextBox.ForeColor = Color.Black;
            }
        }

        private void CheckOutTextBox_Leave(object sender, EventArgs e)
        {
            if (CheckOutTextBox.Text == "")
            {
                CheckOutTextBox.Text = "Enter check out date...";
                CheckOutTextBox.ForeColor = Color.Silver;
            }
        }
    }

    public interface IPresenterCreateReservationPanel : IPresenter
    {

    }

    public class PresenterCreateReservationPanel : INotifyPropertyChanged, IPresenterCreateReservationPanel
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
