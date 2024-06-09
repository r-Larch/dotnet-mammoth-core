namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class EscapeSequences {
        internal static Mammoth.Couscous.java.util.regex.Pattern _PATTERN;
        static EscapeSequences() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences._PATTERN = Mammoth.Couscous.java.util.regex.Pattern.compile("\\\\(.)");
        }
        public static string decode(string value) {
            Mammoth.Couscous.java.util.regex.Matcher matcher = (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences._PATTERN).matcher(value);
            Mammoth.Couscous.java.lang.StringBuilder decoded = new Mammoth.Couscous.java.lang.StringBuilder();
            int lastIndex = 0;
            while (matcher.find()) {
                decoded.append(value.Substring(lastIndex, matcher.start() - lastIndex));
                decoded.append(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences.escapeSequence(matcher.group(1)));
                lastIndex = matcher.end();
            }
            decoded.append(value.Substring(lastIndex, (value.Length) - lastIndex));
            return decoded.toString();
        }
        public static char escapeSequence(string code) {
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

