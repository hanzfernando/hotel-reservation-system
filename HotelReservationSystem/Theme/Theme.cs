using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Theme
{
    public class Theme
    {
        private static PrivateFontCollection _pfc;
        private static Font _font;
        public Theme() { 
            _pfc = new PrivateFontCollection();
            _pfc.AddFontFile("Poppins-Regular.ttf");
            _font = new Font(_pfc.Families[0], 15);

        }
        
        public static PrivateFontCollection PFC { get { return _pfc; } }
        public static Font Font { get { return _font; } }
    }
}
