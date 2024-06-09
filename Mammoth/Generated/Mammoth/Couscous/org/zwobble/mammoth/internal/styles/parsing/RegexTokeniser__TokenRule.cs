using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.regex;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniserTokenRule<T> {
        public Pattern Regex;
        public T Type;

        internal RegexTokeniserTokenRule(T type, Pattern regex)
        {
            if (regex.Matcher("").GroupCount() != 0) {
                throw new RuntimeException("regex cannot contain any groups");
            }

            Type = type;
            Regex = regex;
        }
    }
}
