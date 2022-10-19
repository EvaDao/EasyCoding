using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyCoding
{
    public static class EnumExt
    {
        public static TEnum SafeParse<TEnum>(this string value) where TEnum : struct
        {
            if (Enum.TryParse(value, out TEnum result))
            {
                return result;
            }

            return default(TEnum);
        }

        public static int ToInt32<TEnum>(this TEnum value) where TEnum : struct
        {
            return Convert.ToInt32(value);
        }
    }
}
