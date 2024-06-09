using System;


namespace Mammoth.Couscous.java.io {
    internal class IOException : Exception {
        internal IOException()
        {
        }

        internal IOException(string message) : base(message)
        {
        }

        internal string getMessage()
        {
            return Message;
        }
    }
}
