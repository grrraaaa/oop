using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace lab4
{

    //public class SoapSerializer : ISerializer
    //{
    //    public byte[] Serialize(object obj)
    //    {
    //        using (var stream = new MemoryStream())
    //        {
    //            var formatter = new SoapFormatter();
    //            formatter.Serialize(stream, obj);
    //            return stream.ToArray();
    //        }
    //    }

    //    public T Deserialize<T>(byte[] data)
    //    {
    //        using (var stream = new MemoryStream(data))
    //        {
    //            var formatter = new SoapFormatter();
    //            return (T)formatter.Deserialize(stream);
    //        }
    //    }
    //}
}
