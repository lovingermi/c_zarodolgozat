using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Validations
{
    [Serializable]
    internal class newPasswordValidationException : Exception
    {
        public newPasswordValidationException()
        {
        }

        public newPasswordValidationException(string message) : base(message)
        {
        }

        public newPasswordValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected newPasswordValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}