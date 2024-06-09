using System;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Strings {
        internal static string TrimLeft(string value, int character)
        {
            var index = 0;
            while (index < value.Length && value[index] == character) {
                index++;
            }

            return value.Substring(index);
        }

        internal static bool IsNullOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        internal static bool StartsWithIgnoreCase(string value, string prefix)
        {
            return value.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
