using System;

namespace EasyCoding
{
    public static class Int32Exts
    {
        public static int ToInt32(this object value)
        {
            if (value == null) return default(int);
            return Convert.ToInt32(value);
        }

        public static int? ToNullableInt32(this object value)
        {
            if (value == null) return default(int?);
            var str = value.ToString();
            int.TryParse(str, out var result);
            return result;
        }

        public static int ToInt32(this string value)
        {
            if (value.IsNullOrEmpty()) return default(int);
            int.TryParse(value, out var result);
            return result;
        }

        public static int Fallback(this int? value, int fallbackValue)
            => value ?? fallbackValue;
    }
}
