using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Validations
{
    [Serializable]
    internal class CikkszamValidationException : Exception
    {
        public CikkszamValidationException()
        {
        }

        public CikkszamValidationException(string message) : base(message)
        {
        }

        public CikkszamValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CikkszamValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}