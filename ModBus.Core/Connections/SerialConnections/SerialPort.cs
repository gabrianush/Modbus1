using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Connections.SerialConnections
{
    public class SerialPort
    {
        private static List<string> _ports;
        public const int Count = 14;

        public static List<string> Ports
        {
            get
            {
                _ports = System.IO.Ports.SerialPort.GetPortNames().ToList();
                return _ports;
            }
        }
    }
}
