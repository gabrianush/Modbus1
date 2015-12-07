using ModBus.Core.Connections.Enums;
using ModBus.Core.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Connections
{
    public class Connection
    {
        protected int _timeOut;
        protected List<Device> _devices;


        public virtual ConnectionType ConnectionType
        {
            get { throw new NotImplementedException(); }
        }
        public int TimeOut
        {
            get
            {
                return _timeOut;
            }

            set
            {
                _timeOut = value;
            }
        }

        public List<Device> Devices
        {
            get
            {
                return _devices;
            }

            set
            {
                _devices = value;
            }
        }

        public Connection()
        {
            _devices = new List<Device>();
        }
    }
}
