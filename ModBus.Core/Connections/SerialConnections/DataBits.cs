using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Connections.SerialConnections
{
    public class DataBits
    {
        public static List<int> _dataBits;

        public static List<int> Values
        {
            get
            {
                if(_dataBits == null)
                {
                    _dataBits = new[] { 7, 8 }.ToList();
                }
                return _dataBits;
            }
        }
    }
}
