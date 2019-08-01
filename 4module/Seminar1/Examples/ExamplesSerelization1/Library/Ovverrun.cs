using System;
using System.Runtime.Serialization;

namespace Library
{
    [Serializable]
    public class Ovverrun : Exception
    {
        public Ovverrun()
        {
        }

        public Ovverrun(string message) : base(message)
        {
        }

        public Ovverrun(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Ovverrun(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}