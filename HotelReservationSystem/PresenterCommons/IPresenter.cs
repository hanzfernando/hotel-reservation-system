using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.PresenterCommons
{
    public interface IPresenter
    {
        Form Form { get; set; }
        Panel Panel { get; set; }
    }
}
