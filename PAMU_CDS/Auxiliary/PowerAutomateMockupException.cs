using System;
#if !NET8_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace PAMU_CDS.Auxiliary
{
    public class PowerAutomateException : Exception
    {
        public PowerAutomateException()
        {
        }

        public PowerAutomateException(string message) : base(message)
        {
        }

        public PowerAutomateException(string message, Exception innerException) : base(message, innerException)
        {
        }

#if !NET8_0_OR_GREATER
        protected PowerAutomateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}