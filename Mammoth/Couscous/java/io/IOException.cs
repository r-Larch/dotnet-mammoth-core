using System;


namespace Mammoth.Couscous.java.io {
    internal class IoException : Exception {
        internal IoException()
        {
        }

        internal IoException(string message) : base(message)
        {
        }

        internal string GetMessage()
        {
            return Message;
        }
    }
}
