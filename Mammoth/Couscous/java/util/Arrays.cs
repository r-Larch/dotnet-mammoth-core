namespace Mammoth.Couscous.java.util {
    internal static class Arrays {
        internal static IList<T> AsList<T>(T[] elements)
        {
            return ToJava.ListToList(elements);
        }
    }
}
