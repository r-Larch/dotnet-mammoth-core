using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.java.util.regex;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__Anonymous_2 : Predicate<int> {
        internal Matcher _matcher;

        internal RegexTokeniser__Anonymous_2(Matcher matcher)
        {
            _matcher = matcher;
        }

        public bool test(int index)
        {
            return !Objects.isNull((_matcher).group(index + 1));
        }
    }
}
