using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.regex;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class EscapeSequences {
        internal static Pattern _PATTERN;

        static EscapeSequences()
        {
            _PATTERN = Pattern.compile("\\\\(.)");
        }

        public static string decode(string value)
        {
            var matcher = (_PATTERN).matcher(value);
            var decoded = new StringBuilder();
            var lastIndex = 0;
            while (matcher.find()) {
                decoded.append(value.Substring(lastIndex, matcher.start() - lastIndex));
                decoded.append(escapeSequence(matcher.group(1)));
                lastIndex = matcher.end();
            }

            decoded.append(value.Substring(lastIndex, (value.Length) - lastIndex));
            return decoded.toString();
        }

        public static char escapeSequence(string code)
        {
            switch (code) {
                case "n":
                    return '\n';
                case "r":
                    return '\r';
                case "t":
                    return '\t';
                default:
                    return code.charAt(0);
            }
        }
    }
}
