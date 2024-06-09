using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.regex;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class EscapeSequences {
        private static readonly Pattern Pattern = Pattern.Compile(@"\\(.)");

        public static string Decode(string value)
        {
            var matcher = Pattern.Matcher(value);
            var decoded = new StringBuilder();
            var lastIndex = 0;
            while (matcher.Find()) {
                decoded.Append(value.Substring(lastIndex, matcher.Start() - lastIndex));
                decoded.Append(EscapeSequence(matcher.Group(1)));
                lastIndex = matcher.End();
            }

            decoded.Append(value.Substring(lastIndex, value.Length - lastIndex));
            return decoded.ToString();
        }

        public static char EscapeSequence(string code)
        {
            return code switch {
                "n" => '\n',
                "r" => '\r',
                "t" => '\t',
                _ => code.CharAt(0)
            };
        }
    }
}
