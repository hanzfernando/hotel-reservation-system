using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Constants
{
    public class MySqlConstants
    {
        private static string _connection = "server=localhost;port=3307;username=root;password=;database=hotel_reservation_system";
        public static string Connection { get { return _connection; } }
    }
}
