using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Constants
{
    public class MySqlConstants
    {
        private static string _connection = "";
        public static string Connection { get { return _connection; } };
    }
}
