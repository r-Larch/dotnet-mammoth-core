namespace Mammoth.Couscous.java.lang {
    internal class String {
        internal static string Join(string separator, ITerable<string> values)
        {
            return string.Join(separator, FromJava.IterableToEnumerable(values));
        }
    }
}
