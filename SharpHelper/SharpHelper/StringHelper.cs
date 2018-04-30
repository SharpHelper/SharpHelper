using System;
using System.Diagnostics;
using System.Globalization;

namespace SharpHelper
{
    public static class StringHelper
    {
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static int ToInt32(this string str)
        {
            return Convert.ToInt32(str);
        }
        public static short ToShort(this string str)
        {
            return (short)Convert.ToDecimal(str);
        }

        public static long ToInt64(this string str)
        {
            return Convert.ToInt64(str);
        }
        public static string ReverseString(this string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string GetFirstCharacters(this string str, int amount)
        {
            return str.Substring(0, amount);
        }
        public static char GetFirstCharacter(this string str)
        {
            return str.Substring(0, 1)[0];
        }

        public static T ToEnum<T>(this string value) where T : struct
        {
            Debug.Assert(!string.IsNullOrEmpty(value));
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static string ToTitleCase(this string value)
        {
            if (value == null) return null;
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }
    }
}
