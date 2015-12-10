using ModBus.Core.Connections.Enums;
using ModBus.Core.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Connections
{
    public class Connection : BaseEntity
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

        protected override string ID_PATERN
        {
            get
            {
                return "c{0}";
            }
        }

        public Connection() 
            :this(string.Empty)
        {
        }

        public Connection(string parentId)
            : base(parentId)
        {
            _devices = new List<Device>();
        }
    }
}
