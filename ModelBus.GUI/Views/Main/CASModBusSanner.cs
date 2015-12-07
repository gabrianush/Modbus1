using ModBus.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModBus.Core.Connections.SerialConnections;

namespace ModBus.GUI
{
    public partial class CASModBusSanner : Form
    {
        public CASModBusSanner()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch((new Settings()).ShowDialog())
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Yes: //Apply
                    break;
                default:
                    break;

            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CASModBusSanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Utils.CloseForm(this);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            SerialConnection sc = new SerialConnection();

            int port = 1;
            var ipAddress = new IPAddress(new byte[] { 127, 0, 0, 1 });
            TcpListener lisner = new TcpListener(ipAddress, port);

            int slaveId = 1;
            lock (new object())
            {
                try
                {
                    lisner.Start();

                    // use Socket async API for compact framework compat
           //         lisner.Server.BeginAccept(state => AcceptCompleted(state), this);
                }
                catch (ObjectDisposedException)
                {
                    // this happens when the server stops
                }
            }

        }
    }
}
