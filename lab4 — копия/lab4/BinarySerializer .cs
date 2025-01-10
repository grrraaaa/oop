using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class BinarySerializer 
    {
        //public byte[] Serialize(object obj)
        //{
        //    using (var stream = new MemoryStream())
        //    {
        //        var formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, obj);
        //        return stream.ToArray();
        //    }
        //}

        //public T Deserialize<T>(byte[] data)
        //{
        //    using (var stream = new MemoryStream(data))
        //    {
        //        var formatter = new BinaryFormatter();
        //        return (T)formatter.Deserialize(stream);
        //    }
        //}
    }
}
