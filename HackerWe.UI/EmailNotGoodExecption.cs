using System;
using System.Runtime.Serialization;

namespace HackerWe.UI
{
    [Serializable]
    internal class EmailNotGoodExecption : Exception
    {
        public EmailNotGoodExecption()
        {
        }

        public EmailNotGoodExecption(string? message) : base(message)
        {
        }

        public EmailNotGoodExecption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmailNotGoodExecption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}