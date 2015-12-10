using ModBus.Core.Connections;
using ModBus.Core.Settings;
using ModBus.Core.Utils.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModBus.Core.Utils;
using System.Linq;

namespace ModBus.Core.Services
{
    public class ConnectionsService
    {
        private List<Connection> _connections = null;

        public int ConnectionsCount { get { return _connections.Count; } }

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

        public Connection this[int index]
        {
            get { return _connections[index]; }
        }

        #region Load/Save connections
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
        #endregion

        #region adds connection

        #region events

        public event EventHandler<ConnectionEventArgs> ConnectionAdded;

        protected virtual void OnConnectionAddded(ConnectionEventArgs e)
        {
            EventHandler<ConnectionEventArgs> handler = ConnectionAdded;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion

        public bool AddConnection(Connection conn)
        {
            if (!Exists(conn))
            {
                Connections.Add(conn);
                OnConnectionAddded(new ConnectionEventArgs(conn.Id));
                return true;
            }

            return false;
        }

        #endregion

        #region gets connection
        public Connection GetConnectionById(string id)
        {
            return Connections.FirstOrDefault(c => c.Id == id);
        }
        #endregion

        #region updates connection

        #region events
        public event EventHandler<ConnectionEventArgs> ConnectionUpdated;

        public virtual void OnConnectionUpdated(ConnectionEventArgs e)
        {
            EventHandler<ConnectionEventArgs> handler = ConnectionUpdated;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        #endregion

        public void UpdateConnection(Connection conn)
        {
            var targetConn = GetConnectionById(conn.Id);
            if (targetConn != null)
            {
                int index = Connections.IndexOf(targetConn);
                if (index >= 0)
                {
                    conn.Id = targetConn.Id;
                    Connections[index] = conn;
                    OnConnectionUpdated(new ConnectionEventArgs( conn.Id));
                }
            }
        }

        #endregion

        #region delete connection

        #region events
        public event EventHandler<ConnectionEventArgs> ConnectionDeleted;

        public virtual void OnConnectionDeleted(ConnectionEventArgs e)
        {
            EventHandler<ConnectionEventArgs> handler = ConnectionDeleted;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        #endregion

        public void DeleteConnection(Connection conn)
        {
            if (Exists(conn))
            {
                var targetConn = Connections.FirstOrDefault(c => c.PropertiesEqual(conn));
                if (targetConn != null)
                {
                    Connections.Remove(targetConn);
                    OnConnectionDeleted(new ConnectionEventArgs(targetConn.Id));
                }
            }
        }

        #endregion

        #region misc
        public bool Exists(Connection connection)
        {
            return _connections.Exists(c => c.PropertiesEqual(connection));
        }
        #endregion
    }
}
