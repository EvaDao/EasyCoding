namespace EasyCoding
{
    public static class StringExts
    {
        public static bool IsNullOrEmpty(this string value)
            => string.IsNullOrEmpty(value);

        public static bool IsNullOrWhiteSpace(this string value)
            => string.IsNullOrWhiteSpace(value);

        public static string SafeSubstring(this string value, int startIndex, int length)
        {
            if (value.IsNullOrEmpty())
            {
                return value;
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (value.Length >= startIndex + length)
            {
                return value.Substring(startIndex, length);
            }

            if (value.Length <= startIndex)
            {
                return string.Empty;
            }

            return value.Substring(startIndex);
        }
    }
}
