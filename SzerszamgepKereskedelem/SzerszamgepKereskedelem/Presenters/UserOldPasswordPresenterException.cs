using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Presenters
{
    [Serializable]
    internal class UserOldPasswordPresenterException : Exception
    {
        public UserOldPasswordPresenterException()
        {
        }

        public UserOldPasswordPresenterException(string message) : base(message)
        {
        }

        public UserOldPasswordPresenterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserOldPasswordPresenterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}