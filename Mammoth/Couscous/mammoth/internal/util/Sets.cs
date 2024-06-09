using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Sets {
        internal static ISet<T> Set<T>(T[] values)
        {
            return new HashSet<T>(new System.Collections.Generic.HashSet<T>(values));
        }

        internal static ISet<T> ToSet<T>(ITerable<T> iterable)
        {
            return new HashSet<T>(new System.Collections.Generic.HashSet<T>(FromJava.IterableToEnumerable(iterable)));
        }
    }
}
