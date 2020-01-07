using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Presenters
{
    [Serializable]
    internal class VevoPresenterException : Exception
    {
        public VevoPresenterException()
        {
        }

        public VevoPresenterException(string message) : base(message)
        {
        }

        public VevoPresenterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VevoPresenterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}