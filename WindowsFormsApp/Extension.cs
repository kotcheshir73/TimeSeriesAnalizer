using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public static class Extension
    {
        public static int ToInt(this decimal value)
        {
            return Convert.ToInt32(value);
        }

        public static double ToDouble(this decimal value)
        {
            return Convert.ToDouble(value);
        }

        public static int ToInt(this object value)
        {
            return Convert.ToInt32(value);
        }

        public static double ToDouble(this object value)
        {
            var str = value.ToString();
            if (double.TryParse(str, out double d))
            {
                return d;
            }
            else if (str.Contains(','))
            {
                if (double.TryParse(str.Replace(',', '.'), out d))
                {
                    return d;
                }
            }
            else if (str.Contains('.'))
            {
                if (double.TryParse(str.Replace('.', ','), out d))
                {
                    return d;
                }
            }

            return 0;
        }

        public static bool IsNotEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
