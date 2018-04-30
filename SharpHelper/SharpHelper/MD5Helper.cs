using System.Security.Cryptography;
using System.Text;

namespace SharpHelper
{
    public static class MD5Helper
    {
        public static string Md5Encypt(this string str)
        {
            string hash;
            using (MD5 md5 = MD5.Create())
                hash = GetMd5Hash(md5, str);
            return hash;
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(i.ToString("x2"));

            return sBuilder.ToString();
        }
    }
}
