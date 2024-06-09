using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.java.util.regex;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniserAnonymous2 : IPredicate<int> {
        private Matcher _matcher;

        internal RegexTokeniserAnonymous2(Matcher matcher)
        {
            _matcher = matcher;
        }

        public bool Test(int index)
        {
            return !Objects.IsNull((_matcher).Group(index + 1));
        }
    }
}
