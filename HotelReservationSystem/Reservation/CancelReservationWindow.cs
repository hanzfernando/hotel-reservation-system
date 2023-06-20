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
    public partial class CancelReservationWindow : Form
    {
        
        private PresenterCancelReservationWindow _presenter;
        public PresenterCancelReservationWindow Presenter { get { return _presenter; } }
        public CancelReservationWindow()
        {
            InitializeComponent();
            _presenter = new PresenterCancelReservationWindow();
            this.CenterToParent();
        }

        private void YesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _presenter.IsCancelled = true;
            this.Hide();
        }

        private void NoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _presenter.IsCancelled = false;
            this.Hide();
        }

        
    }

    public interface IPresenterCancelReservationWindow : IPresenter
    {
        bool IsCancelled { get; set; }
    }

    public class PresenterCancelReservationWindow : INotifyPropertyChanged , IPresenterCancelReservationWindow
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Form _form;
        private Panel _panel;
        private bool _isCancelled;
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

        public bool IsCancelled
        {
            get { return _isCancelled; }
            set { _isCancelled = value; }
        }

    }


}
