using System;
using System.Runtime.Serialization;

namespace SzerszamgepKereskedelem.Presenters
{
    [Serializable]
    internal class ModifyPresenterException : Exception
    {
        public ModifyPresenterException()
        {
        }

        public ModifyPresenterException(string message) : base(message)
        {
        }

        public ModifyPresenterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModifyPresenterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}