using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class XmlSerializer : ISerializer
    {
        public byte[] Serialize(object obj)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
        }

        public T Deserialize<T>(byte[] data)
        {
            using (var stream = new MemoryStream(data))
            {
                var formatter = new System.Xml.Serialization.XmlSerializer(typeof(T));
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
