using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Validations
{
    [Serializable]
    internal class UserOldPasswordValidationException : Exception
    {
        public UserOldPasswordValidationException()
        {
        }

        public UserOldPasswordValidationException(string message) : base(message)
        {
        }

        public UserOldPasswordValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserOldPasswordValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}