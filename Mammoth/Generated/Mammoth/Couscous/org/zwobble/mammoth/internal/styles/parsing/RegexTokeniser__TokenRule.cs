namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser__TokenRule {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__TokenRule<T> {
        internal T _type;
        internal Mammoth.Couscous.java.util.regex.Pattern _regex;
        internal RegexTokeniser__TokenRule(T type, Mammoth.Couscous.java.util.regex.Pattern regex) {
            if ((regex.matcher("")).groupCount() != 0) {
                throw new Mammoth.Couscous.java.lang.RuntimeException("regex cannot contain any groups");
            }
            this._type = type;
            this._regex = regex;
        }
    }
}

