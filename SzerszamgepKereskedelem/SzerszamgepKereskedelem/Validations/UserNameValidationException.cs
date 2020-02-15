using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Validations
{
    [Serializable]
    internal class UserNameValidationException : Exception
    {
        public UserNameValidationException()
        {
        }

        public UserNameValidationException(string message) : base(message)
        {
        }

        public UserNameValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNameValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}