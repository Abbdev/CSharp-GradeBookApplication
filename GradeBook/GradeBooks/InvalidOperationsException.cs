using System;
using System.Runtime.Serialization;

namespace GradeBook.GradeBooks
{
    [Serializable]
    internal class InvalidOperationsException : Exception
    {
        public InvalidOperationsException()
        {
        }

        public InvalidOperationsException(string message) : base(message)
        {
        }

        public InvalidOperationsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidOperationsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}