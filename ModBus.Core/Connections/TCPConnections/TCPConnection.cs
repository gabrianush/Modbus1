using ModBus.Core.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModBus.Core.Connections.Enums;

namespace ModBus.Core.Connections.TCPConnections
{
    public class TCPConnection : Connection
    {

        private string _iPAddress;
        private int _port;

        public override ConnectionType ConnectionType
        {
            get
            {
                return ConnectionType.Tcp;
            }
        }

        public string IPAddress
        {
            get
            {
                return _iPAddress;
            }

            set
            {
                _iPAddress = value;
            }
        }

        public int Port
        {
            get
            {
                return _port;
            }

            set
            {
                _port = value;
            }
        }

        public override string ToString()
        {
            return string.Format("TCP {0}:{1} timeout: {2}", IPAddress, Port, TimeOut);
        }
    }

}
