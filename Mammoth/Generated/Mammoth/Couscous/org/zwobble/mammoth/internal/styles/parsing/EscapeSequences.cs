using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.regex;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class EscapeSequences {
        private static Pattern _pattern;

        static EscapeSequences()
        {
            _pattern = Pattern.Compile("\\\\(.)");
        }

        public static string Decode(string value)
        {
            var matcher = (_pattern).Matcher(value);
            var decoded = new StringBuilder();
            var lastIndex = 0;
            while (matcher.Find()) {
                decoded.Append(value.Substring(lastIndex, matcher.Start() - lastIndex));
                decoded.Append(EscapeSequence(matcher.Group(1)));
                lastIndex = matcher.End();
            }

            decoded.Append(value.Substring(lastIndex, (value.Length) - lastIndex));
            return decoded.ToString();
        }

        public static char EscapeSequence(string code)
        {
            switch (code) {
                case "n":
                    return '\n';
                case "r":
                    return '\r';
                case "t":
                    return '\t';
                default:
                    return code.CharAt(0);
            }
        }
    }
}
