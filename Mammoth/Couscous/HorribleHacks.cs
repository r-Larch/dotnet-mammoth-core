using System;


namespace Mammoth.Couscous {
    internal static class HorribleHacks {
        internal static bool equals(this object first, object second)
        {
            return first.Equals(second);
        }

        internal static string getMessage(this Exception exception)
        {
            return exception.Message;
        }
    }
}
