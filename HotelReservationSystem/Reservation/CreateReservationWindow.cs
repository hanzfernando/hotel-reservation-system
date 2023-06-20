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
    public partial class CreateReservationWindow : Form
    {
        private PresenterReservationWindow _presenter;
        public PresenterReservationWindow Presenter { get { return _presenter; } }
        public CreateReservationWindow()
        {
            InitializeComponent();
            _presenter = new PresenterReservationWindow();
            
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (_presenter.PanelName == "create")
            {
                CreateReservationPanel createReservation = new CreateReservationPanel();
                createReservation.Presenter.Form = this;
                createReservation.Presenter.Panel = _presenter.Panel;
                createReservation.Presenter.AdminId = _presenter.AdminId;
                this.createReservationPanel.Controls.Add(createReservation);
            }
            else
            {
                EditReservationPanel editReservation = new EditReservationPanel();
                editReservation.Presenter.Form = this;
                editReservation.Presenter.Panel = _presenter.Panel;
                editReservation.Presenter.AdminId = _presenter.AdminId;
                this.createReservationPanel.Controls.Add(editReservation);
            }
            
            
        }
    }

    public interface IPresenterReservationWindow : IPresenter
    {
        int AdminId { get; set; }
    }

    public class PresenterReservationWindow : INotifyPropertyChanged, IPresenterReservationWindow
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Form _form;
        private Panel _panel;
        private int _adminid;
        private string _panelName;


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

        public string PanelName
        {
            get { return _panelName; }
            set { _panelName = value; }
        }

        public int AdminId { get { return _adminid; } set { _adminid = value; } }
        
    }
}
