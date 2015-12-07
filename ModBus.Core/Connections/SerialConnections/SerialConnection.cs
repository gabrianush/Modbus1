using ModBus.Core.Connections;
using ModBus.Core.Connections.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ports = System.IO.Ports;

namespace ModBus.Core.Connections.SerialConnections
{
    public class SerialConnection : Connection
    {
        private string _portName;
        private int _baudRate;
        private int _dataBits;
        private int _stopBits;
        private Ports.Parity _parity;

        public override ConnectionType ConnectionType
        {
            get
            {
                return ConnectionType.Serial;
            }
        }

        public override bool Equals(object obj)
        {
            SerialConnection serial = obj as SerialConnection;
            if (serial == null) return false;
            return PortName == serial.PortName
                    && BaudRate == serial.BaudRate;
                    //&& 
        }
        public string PortName
        {
            get
            {
                return _portName;
            }

            set
            {
                _portName = value;
            }
        }

        public int BaudRate
        {
            get
            {
                return _baudRate;
            }

            set
            {
                _baudRate = value;
            }
        }

        public int DataBits
        {
            get
            {
                return _dataBits;
            }

            set
            {
                _dataBits = value;
            }
        }

        public int StopBits
        {
            get
            {
                return _stopBits;
            }

            set
            {
                _stopBits = value;
            }
        }

        public Ports.Parity Parity
        {
            get
            {
                return _parity;
            }

            set
            {
                _parity = value;
            }
        }
    }
}
