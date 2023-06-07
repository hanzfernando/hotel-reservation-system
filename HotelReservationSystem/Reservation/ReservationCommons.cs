using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Reservation
{   
    /*public class ReservationCommons : UserControl, IReservationCommons
    {
        private IPresenterReservationCommons _presenter;
        public IPresenterReservationCommons Presenter => _presenter;

        
    }*/

    public interface IReservationCommons : IContainerControl
    {
        IPresenterReservationCommons Presenter { get; }
    }

    public interface IPresenterReservationCommons
    {
        int Height { get; set; }
        int Width { get; set; }
    }

    
}
