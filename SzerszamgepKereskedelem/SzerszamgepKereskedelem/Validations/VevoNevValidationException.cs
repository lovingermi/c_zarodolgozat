using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Validations
{
    [Serializable]
    internal class VevoNevValidationException : Exception
    {
        public VevoNevValidationException()
        {
        }

        public VevoNevValidationException(string message) : base(message)
        {
        }

        public VevoNevValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VevoNevValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}