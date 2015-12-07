using ModBus.Core.Transactions.WriteTransactions.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Transactions.WriteTransactions
{
    class WriteTransaction : Transaction
    {
        private WriteTask _writeTask;
        private int _value;

        public WriteTask WriteTask
        {
            get
            {
                return _writeTask;
            }

            set
            {
                _writeTask = value;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }
    }
}
