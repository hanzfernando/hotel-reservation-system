using HotelReservationSystem.Login;
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
        private PresenterReservationPanel _presenter;

        public ReservationPanel()
        {
            InitializeComponent();
            _presenter = new PresenterReservationPanel();
            this._presenter.FlowLayoutPanel = ReservationLayoutPanel;
            
            this.ListPanel.Parent = PinkBG;
            this.ReservationLayoutPanel.Parent = ListPanel;
        }

        private void AddControl_Click(object sender, EventArgs e)
        {
            ReservationLayoutPanel.Controls.Add(new Item());
        }

        private void OnLoad(object sender, EventArgs e)
        {
            List<IReservationCommons> reservation = _presenter.ItemList;
            reservation.Add(new ListHeader());
            _presenter.ItemList = reservation;
            foreach (UserControl item in _presenter.ItemList)
            {
                ReservationLayoutPanel.Controls.Add(item);
            }

        }

       /* private void OnScroll(object sender, EventArgs e)
        {
            if (_presenter.Scrollable)
            {
                _presenter.Scrollable = false;
            }
            else
            {
                _presenter.Scrollable = true;
            }

        }*/

        public PresenterReservationPanel Presenter { get { return _presenter; } }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            List <IReservationCommons> reservation = _presenter.ItemList;
            reservation.Add(new ListHeader());
            _presenter.ItemList = reservation;
        }
    }

    public interface IPresenterReservationPanel : IPresenter
    {
        /*Boolean Scrollable { get; set; }*/ 
        List <IReservationCommons> ItemList { get; set; }
        FlowLayoutPanel FlowLayoutPanel { get; set; }
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
        private Boolean _scrollable;
        private List <IReservationCommons> _itemList = new List<IReservationCommons>();
        private FlowLayoutPanel _flowlayoutpanel;

        public Form Form { get { return _form; } set { _form = value; } }
        public Panel Panel { get { return _panel; } set { _panel = value; } }
        /*public Boolean Scrollable { get { return _scrollable; }
            set { _scrollable = value;
                OnPropertyChanged(nameof(Scrollable));
                ChangeWidth();
            }
        }*/
        public FlowLayoutPanel FlowLayoutPanel { get { return _flowlayoutpanel; } set { _flowlayoutpanel = value; } }


        public List<IReservationCommons> ItemList { get { return _itemList; } 
            set { 
                
                 _itemList = value;
                 OnPropertyChanged(nameof(ItemList));
                 _flowlayoutpanel.Controls.Clear();
                 RebuildList(value);
                
            } 
        }

        /*private void ChangeWidth()
        {
            if (Scrollable) 
            {
                for(int i = 0; i < ItemList.Count; i++)
                {
                    ItemList.ElementAt(i).Presenter.Height = 30;
                    ItemList.ElementAt(i).Presenter.Width = 744;

                }
            }
            else
            {
                for (int i = 0; i < ItemList.Count; i++)
                {
                    ItemList.ElementAt(i).Presenter.Height = 30;
                    ItemList.ElementAt(i).Presenter.Width = 774;

                }
            }
        }*/

        private void RebuildList(List<IReservationCommons> reservationcommons)
        {
            for(int i = 0; i < ItemList.Count ; i++)
            {
                _flowlayoutpanel.Controls.Add((Control)reservationcommons.ElementAt(i));
            }
        }

        /*public void ListChanged()
        {
            OnPropertyChanged(nameof(ItemList));
        }*/
    }
}
