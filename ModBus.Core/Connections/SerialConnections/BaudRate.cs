using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Connections.SerialConnections
{
    public class BaudRates
    {
        private static List<int> _values;

        public static List<int> Values
        {
            get
            {
                if (_values == null)
                {
                    _values = new[] { 110, 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200, 230400, 460800, 921600 }
                                    .ToList();
                }
                return _values;
            }
        }
    }
}
