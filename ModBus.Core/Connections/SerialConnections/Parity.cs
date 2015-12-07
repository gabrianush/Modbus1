using ModBus.Core.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ports = System.IO.Ports;

namespace ModBus.Core.Connections.SerialConnections
{
    public class Parity
    {
        private static List<Ports.Parity> _values;

        public static List<Ports.Parity> Values
        {
            get
            {
                if (_values == null) {
                    _values = EnumExtensions.GetValues<Ports.Parity>();
                }
                return _values;
            }
        }
    }
}
