using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Interfejsy.Exceptions
{
    [Serializable]
    public class MyException : System.Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, System.Exception inner) : base(message, inner) { }
        protected MyException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
