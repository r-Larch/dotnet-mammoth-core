using System;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Casts {
        internal static Optional<T> tryCast<T>(Type type, object value)
        {
            if (value is T) {
                return new Some<T>((T) value);
            }

            return None<T>.Instance;
        }
    }
}
