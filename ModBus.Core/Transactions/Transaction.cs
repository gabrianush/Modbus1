using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Transactions
{
    public class Transaction : BaseEntity
    {
        protected int _offset;
        protected int _length;
        public int Offset
        {
            get
            {
                return _offset;
            }

            set
            {
                _offset = value;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }

        protected override string ID_PATERN
        {
            get
            {
                return "{1}_t{0}";
            }
        }

        public Transaction(string parentId) 
            : base(parentId)
        {

        }
    }
}
