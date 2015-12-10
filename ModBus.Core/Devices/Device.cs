using ModBus.Core.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Devices
{
    public class Device : BaseEntity
    {
        const string ID_PATTERN = "{0}_d{1}";
        private int _slaveID;
        private List<Transaction> _transactions;
        private Guid _guid;

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

        protected override string ID_PATERN
        {
            get
            {
                return "{1}_d{0}";
            }
        }

        public Device(string parentId) : 
            base(parentId)
        {
            _transactions = new List<Transactions.Transaction>();
        }
    }
}
