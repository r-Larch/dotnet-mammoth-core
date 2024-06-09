using System;
using System.Text.RegularExpressions;


namespace Mammoth.Couscous {
    internal static class JavaStringExtensions {
        internal static char CharAt(this string value, int index)
        {
            return value[index];
        }

        internal static bool EqualsIgnoreCase(this string first, string second)
        {
            return first.Equals(second, StringComparison.InvariantCultureIgnoreCase);
        }

        internal static string Replace(this string original, string search, string replacement)
        {
            return original.Replace(search, replacement);
        }

        internal static bool IsEmpty(this string value)
        {
            return value.Length == 0;
        }

        internal static bool StartsWith(this string value, string prefix)
        {
            return value.StartsWith(prefix);
        }

        internal static string Trim(this string value)
        {
            return value.Trim();
        }

        internal static string[] Split(this string value, string separator)
        {
            return Regex.Split(value, separator);
        }

        internal static int IndexOf(this string value, string search)
        {
            return value.IndexOf(search);
        }

        internal static int LastIndexOf(this string value, string search)
        {
            return value.LastIndexOf(search);
        }
    }
}
