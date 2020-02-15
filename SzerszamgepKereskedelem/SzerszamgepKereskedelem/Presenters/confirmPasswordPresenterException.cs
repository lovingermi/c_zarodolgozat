using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Presenters
{
    [Serializable]
    internal class confirmPasswordPresenterException : Exception
    {
        public confirmPasswordPresenterException()
        {
        }

        public confirmPasswordPresenterException(string message) : base(message)
        {
        }

        public confirmPasswordPresenterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected confirmPasswordPresenterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}