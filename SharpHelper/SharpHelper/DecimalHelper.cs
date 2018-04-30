using System;

namespace SharpHelper
{
    public static class DecimalHelper
    {
        public static bool HasDecimal(this decimal value)
        {
            return (value - Math.Round(value) != 0);
        }

        public static int CalculateNumberPage(this decimal value)
        {
            if (value - Math.Round(value) != 0)
            {
                value++;
                return GetIntPart(value);
            }
            return GetIntPart(value);
        }

        public static int GetIntPart(this decimal value)
        {
            return (int)Math.Truncate(value);
        }
    }
}
