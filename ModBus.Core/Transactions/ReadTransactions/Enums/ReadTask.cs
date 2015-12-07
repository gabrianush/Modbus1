using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Transactions.ReadTransactions.Enum
{
    public enum ReadTask
    {
        ReadCoilStatus,
        ReadInputStatus,
        ReadHoldingRegisters,
        ReadInputRegisters
    }
}
