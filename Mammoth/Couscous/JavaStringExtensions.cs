using System;
using System.Text.RegularExpressions;


namespace Mammoth.Couscous {
    internal static class JavaStringExtensions {
        internal static char charAt(this string value, int index)
        {
            return value[index];
        }

        internal static bool equalsIgnoreCase(this string first, string second)
        {
            return first.Equals(second, StringComparison.InvariantCultureIgnoreCase);
        }

        internal static string replace(this string original, string search, string replacement)
        {
            return original.Replace(search, replacement);
        }

        internal static bool isEmpty(this string value)
        {
            return value.Length == 0;
        }

        internal static bool startsWith(this string value, string prefix)
        {
            return value.StartsWith(prefix);
        }

        internal static string trim(this string value)
        {
            return value.Trim();
        }

        internal static string[] split(this string value, string separator)
        {
            return Regex.Split(value, separator);
        }

        internal static int indexOf(this string value, string search)
        {
            return value.IndexOf(search);
        }

        internal static int lastIndexOf(this string value, string search)
        {
            return value.LastIndexOf(search);
        }
    }
}
