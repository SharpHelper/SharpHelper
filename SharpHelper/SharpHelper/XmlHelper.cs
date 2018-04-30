using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SharpHelper
{
    public static class XmlHelper
    {
        public static T ToObject<T>(this string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (var memStream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                var resultingMessage = (T)serializer.Deserialize(memStream);
                return resultingMessage;
            }
        }

        public static string ToXml<T>(this object obj) where T : new()
        {
            using (var ms = new MemoryStream())
            {
                using (var xw = XmlWriter.Create(ms))
                {
                    var serializer = new XmlSerializer(obj.GetType());
                    serializer.Serialize(xw, obj);
                    xw.Flush();
                    ms.Seek(0, SeekOrigin.Begin);
                    var sr = new StreamReader(ms, Encoding.UTF8);
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
