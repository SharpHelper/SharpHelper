namespace SharpHelper
{
    public static class ObjectHelper
    {
        /// <summary>
        /// Verify if a object is null, or not.
        /// </summary>
        /// <param name="obj">object to verify</param>
        /// <returns>True if it's null, or false if it's not.</returns>
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
    }
}
