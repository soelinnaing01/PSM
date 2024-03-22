using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Services
{
    public static class DevCode
    {
        public static int ToInt32(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static T ToEnum<T>(this string str) where T : Enum 
        {
            return (T)Enum.Parse(typeof(T), str, true);
        }

        public static string ToThousandSeparator(this decimal dec)
        {
            return dec.ToString("n0");
        }
    }
}
