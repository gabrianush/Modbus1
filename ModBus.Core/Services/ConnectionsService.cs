using ModBus.Core.Connections;
using ModBus.Core.Settings;
using ModBus.Core.Utils.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Services
{
    public class ConnectionsService
    {
        private List<Connection> _connections = null;

        public List<Connection> Connections
        {
            get
            {
                return _connections;
            }

            set
            {
                _connections = value;
            }
        }

        public ConnectionsService()
        {
            _connections = new List<Connection>();
        }

        public void Load()
        {
            if(!File.Exists(Config.CONNECTIONS_FILE_PATH)) { return; }

            using (StreamReader reader = new StreamReader(Config.CONNECTIONS_FILE_PATH))
            {
                _connections = JsonUtils<List<Connection>>.Deserialize(reader.ReadToEnd()) ?? new List<Connection>();
            }
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(Config.CONNECTIONS_FILE_PATH))
            {
                writer.Write(JsonUtils<List<Connection>>.Serialize(_connections));
            }
        }

        public bool Exits(Connection connection)
        {
            return _connections.Exists();
        }
    }
}
