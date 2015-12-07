using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Utils.Extensions
{
    public static class EnumExtensions
    {
        public static List<T> GetValues<T>()
        {
            var type = typeof(T);
            if (!type.IsEnum)
            {
                throw new ArgumentException("The argument is not a enum type");
            }
            return Enum.GetValues(typeof(T)).Cast<T>().ToList<T>();
        }

        public static T GetValue<T>(string strValue)
        {
            return (T)Enum.Parse(typeof(T), strValue);
        }
    }
}
