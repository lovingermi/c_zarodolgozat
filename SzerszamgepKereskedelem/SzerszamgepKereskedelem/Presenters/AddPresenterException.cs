using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Presenters
{
    [Serializable]
    internal class AddPresenterException : Exception
    {
        public AddPresenterException()
        {
        }

        public AddPresenterException(string message) : base(message)
        {
        }

        public AddPresenterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AddPresenterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}