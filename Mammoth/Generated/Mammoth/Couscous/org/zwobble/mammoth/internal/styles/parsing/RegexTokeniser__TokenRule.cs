using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.regex;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser__TokenRule {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__TokenRule<T> {
        public Pattern _regex;
        public T _type;

        internal RegexTokeniser__TokenRule(T type, Pattern regex)
        {
            if ((regex.matcher("")).groupCount() != 0) {
                throw new RuntimeException("regex cannot contain any groups");
            }

            _type = type;
            _regex = regex;
        }
    }
}
