using HotelReservationSystem.PresenterCommons;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                
        private void CreateRecordButton_Click(object sender, EventArgs e)
        {
            string[] strings = { "Enter first name...", "Enter last name...", "Enter room unit..." };
            bool[] inputStatus = new bool[3];

            if (FirstNameTextBox.Text == strings[0] || FirstNameTextBox.Text == "")
            {
                inputStatus[0] = true;
            }

            if (LastNameTextBox.Text == strings[1] || LastNameTextBox.Text == "")
            {
                inputStatus[1] = true;
            }

            if (RoomUnitTextBox.Text == strings[2] || RoomUnitTextBox.Text == "")
            {
                inputStatus[2] = true;
            }

            string message = "";
            string[] fieldName = { "First Name", "Last Name", "Room Unit" };

            for (int i = 0; i < inputStatus.Length; i++)
            {
                if (inputStatus[i])
                {
                    message += "Invalid Input on " + fieldName[i] + Environment.NewLine;
                }
            }

            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);

        }
    }

    public interface IPresenterCreateReservationPanel : IPresenter
    {
        int AdminId { get; set; }

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
        private int _adminid;


        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }
        public int AdminId { get { return _adminid; } set { _adminid = value; } }

    }
}
