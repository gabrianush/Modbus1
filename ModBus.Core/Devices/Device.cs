using ModBus.Core.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Devices
{
    public class Device
    {
        private int _slaveID;
        private List<Transaction> _transactions;
        public int SlaveID
        {
            get
            {
                return _slaveID;
            }

            set
            {
                _slaveID = value;
            }
        }

        public List<Transaction> Transaction
        {
            get
            {
                return _transactions;
            }

            set
            {
                _transactions = value;
            }
        }

        public Device()
        {
            _transactions = new List<Transactions.Transaction>();
        }
    }
}
