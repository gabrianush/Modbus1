using ModBus.Core.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Services
{
    public class ConnectionEventArgs : EventArgs
    {
        public string ConnectionId { get; protected set; }

        public ConnectionEventArgs(string connId)
        {
            ConnectionId = connId;
        }
    }
}
