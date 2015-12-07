using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Transactions.WriteTransactions.Enum
{
    public enum WriteTask
    {
        ForceSingleCoil,
        ForceSingleRegister,
        ForceMultipleCoils,
        ForceMultipleRegisters
    }
}
