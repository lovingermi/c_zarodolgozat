using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Presenters
{
    [Serializable]
    internal class newPasswordPresenterException : Exception
    {
        public newPasswordPresenterException()
        {
        }

        public newPasswordPresenterException(string message) : base(message)
        {
        }

        public newPasswordPresenterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected newPasswordPresenterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}