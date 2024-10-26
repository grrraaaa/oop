using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Exceptions
    {
        public class InvalidProductException : Exception
        {
            public InvalidProductException(string message) : base(message) { }
        }

        public class MemoryOverflowException : OutOfMemoryException
        {
            public MemoryOverflowException(string message) : base(message) { }
        }

        public class FileReadException : IOException
        {
            public FileReadException(string message) : base(message) { }
        }
    }
}
