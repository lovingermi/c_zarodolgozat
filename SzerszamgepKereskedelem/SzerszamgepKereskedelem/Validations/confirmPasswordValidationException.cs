using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Validations
{
    [Serializable]
    internal class confirmPasswordValidationException : Exception
    {
        public confirmPasswordValidationException()
        {
        }

        public confirmPasswordValidationException(string message) : base(message)
        {
        }

        public confirmPasswordValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected confirmPasswordValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}