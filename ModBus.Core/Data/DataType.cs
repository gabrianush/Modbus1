using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Data
{
    /// <summary>
    ///     Types of data supported by the Modbus protocol.
    /// </summary>
    public enum DataType
    {
        /// <summary>
        ///     read/write register
        /// </summary>
        HoldingRegister,

        /// <summary>
        ///     readonly register
        /// </summary>
        InputRegister,

        /// <summary>
        ///     read/write discrete
        /// </summary>
        Coil,

        /// <summary>
        ///     readonly discrete
        /// </summary>
        Input
    }
}
