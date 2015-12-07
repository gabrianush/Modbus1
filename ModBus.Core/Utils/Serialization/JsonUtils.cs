using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModBus.Core.Utils.Serialization
{
    public static class JsonUtils<T> where T : class
    {
        public static T Deserialize(string value)
        {
            T obj = null;
            try
            {
                obj = JsonConvert.DeserializeObject<T>(value);
            }
            catch
            {
                //
            }

            return obj;
        }

        public static string Serialize(T obj)
        {
            string value = null;
            try
            {
                value = JsonConvert.SerializeObject(obj);
            }
            catch
            {
                //
            }
            return value;
        }
    }
}
