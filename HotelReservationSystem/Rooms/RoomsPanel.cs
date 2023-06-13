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
    public partial class RoomsPanel : UserControl
    {
        private PresenterRoomsPanel _presenter;

        public PresenterRoomsPanel Presenter { get { return _presenter; } }

        public RoomsPanel()
        {
            InitializeComponent();
            _presenter = new PresenterRoomsPanel();
            for (int i =0; i < 6; i++)
            {
                Floor floor = new Floor();
                floor.Presenter.FloorNumber = i+1;
                flowLayoutPanel1.Controls.Add(floor);
            }
        }
    }

    public interface IPresenterRoomsPanel: IPresenter
    {

    }

    public class PresenterRoomsPanel : INotifyPropertyChanged, IPresenterRoomsPanel
    {

        private Form _form;
        private Panel _panel;


        public Form Form
        {
            get { return _form; }
            set { _form = value; }
        }

        public Panel Panel
        {
            get { return _panel; }
            set { _panel = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
