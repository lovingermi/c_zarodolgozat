using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Presenters
{
    [Serializable]
    internal class UserNamePresenterException : Exception
    {
        public UserNamePresenterException()
        {
        }

        public UserNamePresenterException(string message) : base(message)
        {
        }

        public UserNamePresenterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNamePresenterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}