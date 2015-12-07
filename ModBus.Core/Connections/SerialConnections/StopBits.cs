using ModBus.Core.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ports = System.IO.Ports;

namespace ModBus.Core.Connections.SerialConnections
{
    public class StopBits
    {
        private static List<Ports.StopBits> _values;

        public static List<Ports.StopBits> Values
        {
            get
            {
                if (_values == null)
                {
                    _values = EnumExtensions.GetValues<Ports.StopBits>();
                }

                return _values;
            }
        }
    }
}
