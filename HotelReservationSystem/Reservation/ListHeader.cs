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
    public partial class ListHeader : UserControl, IReservationCommons
    {
        private PresenterListHeader _presenter;
        public ListHeader()
        {
            InitializeComponent();
            _presenter = new PresenterListHeader();
        }

        public IPresenterReservationCommons Presenter => _presenter;

        private void OnLoad(object sender, EventArgs e)
        {
            this.Height = _presenter.Height;
            this.Width = _presenter.Width;
        }
    }

    public interface IPresenterListHeader : IPresenter, IPresenterReservationCommons
    {
        
    }

    public class PresenterListHeader : INotifyPropertyChanged, IPresenterListHeader
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Form _form;
        private Panel _panel;
        private int _height = 30;
        private int _width = 774;

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }
        public int Height { get { return _height; } 
            set 
            { 
                _height = value;
                OnPropertyChanged(nameof(Height));
            } 
        }
        public int Width { get { return _width; } 
            set
            {
                _width = value;
                OnPropertyChanged(nameof(Width));
            }
        }
    }
}
