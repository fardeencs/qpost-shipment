namespace CommonLib.CustomExtentions
{
    using System;
    public static class CommonExtension
    {
        public static bool IsWithin(this int value, int minimum, int maximum)
        {
            return value >= minimum && value <= maximum;
        }

        public static string TruncateLongString(this string str, int maxLength)
        {
            return str.Substring(0, Math.Min(str.Length, maxLength));
        }

        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        //public static string EnumToString(this enum value)
        //{
        //    return value.ToString();
        //}
    }
}
