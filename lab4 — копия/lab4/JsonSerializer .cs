using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class JsonSerializer : ISerializer
    {
        public byte[] Serialize(object obj)
        {
            return Encoding.UTF8.GetBytes(System.Text.Json.JsonSerializer.Serialize(obj));
        }

        public T Deserialize<T>(byte[] data)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(data));
        }
    }

}
