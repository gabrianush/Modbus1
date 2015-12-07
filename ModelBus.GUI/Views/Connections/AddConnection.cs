using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModBus.Core.Utils.Extensions;
using CUtils = ModBus.Core.Utils.Utils;
using ModBus.Core.Connections;
using SerialConns = ModBus.Core.Connections.SerialConnections;
using TcpConns = ModBus.Core.Connections.TCPConnections;
using Ports = System.IO.Ports;

namespace ModBus.GUI
{
    public partial class AddConnection : Form
    {

        public Connection Connection { get; private set; }
        public AddConnection()
        {
            InitializeComponent();
        }

        private void AddConnection_Load(object sender, EventArgs e)
        {
            try
            {
                InitComponent();
            }
            catch(Exception ex)
            {
                grbSerial.Enabled = false;
                Utils.ShowError(this, ex.Message);
            }
        }

        private void InitComponent()
        {
            #region load ports
            var ports = SerialConns.SerialPort.Ports.Cast<object>().ToArray();
            if(!ports.Any())
            {
                throw new InvalidOperationException(CUtils.PORT_NOT_FOUND);
            }
            cmbPortName.Items.AddRange(ports);
            cmbPortName.SelectedIndex = 0;
            #endregion

            #region load baud rates
            var baudRates = SerialConns.BaudRates.Values.Cast<object>().ToArray();
            if(!baudRates.Any())
            {
                throw new InvalidOperationException(CUtils.BAUD_RATE_NOT_FOUND);
            }
            cmbBaudeRate.Items.AddRange(baudRates);
            cmbBaudeRate.SelectedIndex = 0;
            #endregion

            #region load data bits
            var dataBits = SerialConns.DataBits.Values.Cast<object>().ToArray();
            if (!dataBits.Any())
            {
                throw new InvalidOperationException(CUtils.DATA_BITS_NOT_FOUND);
            }
            cmbDataBits.Items.AddRange(dataBits);
            cmbDataBits.SelectedIndex = 0;
            #endregion

            #region load stop bits
            var stopBits = SerialConns.StopBits.Values.Cast<object>().ToArray();
            if (!stopBits.Any())
            {
                throw new InvalidOperationException(CUtils.STOP_BITS_NOT_FOUND);
            }
            cmbStopBits.Items.AddRange(stopBits);
            cmbStopBits.SelectedIndex = 0;
            #endregion

            #region load parity
            var parity = SerialConns.Parity.Values.Cast<object>().ToArray();
            if (!parity.Any())
            {
                throw new InvalidOperationException(CUtils.PARITY_NOT_FOUND);
            }
            cmbParity.Items.AddRange(parity);
            cmbParity.SelectedIndex = 0;
            #endregion

            #region timeout(s)
            nudSerialTimeOut.Minimum = nudTcpTimeOut.Minimum = 0;
            #endregion

            #region ip address
            mtxtIP.ValidatingType = typeof(System.Net.IPAddress);
            #endregion
        }

        private void maskedTextBoxIP_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if(e.ReturnValue == null)
            {

                Utils.ShowError(this, CUtils.IP_ADDRESS_INVALID);
            }
        }

        private void buttonAddSerialConnection_Click(object sender, EventArgs e)
        {
            Connection = new SerialConns.SerialConnection
            {
                BaudRate = int.Parse(cmbBaudeRate.SelectedValue.ToString()),
                DataBits = int.Parse(cmbDataBits.SelectedValue.ToString()),
                Parity = EnumExtensions.GetValue<Ports.Parity>(cmbParity.SelectedValue.ToString()),
                PortName = cmbPortName.SelectedValue.ToString(),
                StopBits = int.Parse(cmbStopBits.SelectedValue.ToString()),
                TimeOut = (int)nudSerialTimeOut.Value
            };
        }

        private void buttonAddTCPConnection_Click(object sender, EventArgs e)
        {
            Connection = new TcpConns.TCPConnection
            {
                IPAddress = mtxtIP.ValidateText().ToString(),
                Port = (int)nudPort.Value,
                TimeOut = (int)nudTcpTimeOut.Value
            };
        }
    }
}
