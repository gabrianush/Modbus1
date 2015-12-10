using ModBus.Core.Transactions.ReadTransactions.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Transactions.ReadTransactions
{
    class ReadTransaction : Transaction
    {
        private ReadTask _readTask;
        public ReadTask RequestFunction
        {
            get
            {
                return _readTask;
            }

            set
            {
                _readTask = value;
            }
        }

        public ReadTransaction(string parentId)
            : base(parentId)
        {

        }
    }
}
