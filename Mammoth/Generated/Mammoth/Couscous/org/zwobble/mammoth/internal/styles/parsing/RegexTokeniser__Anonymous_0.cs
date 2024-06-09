using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.java.util.regex;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniserAnonymous0<T> : IFunction<RegexTokeniserTokenRule<T>, string> {
        public string Apply(RegexTokeniserTokenRule<T> rule)
        {
            return $"({rule.Regex.Value})";
        }
    }

    internal class RegexTokeniserAnonymous1<T> : IFunction<RegexTokeniserTokenRule<T>, T> {
        public T Apply(RegexTokeniserTokenRule<T> rule)
        {
            return rule.Type;
        }
    }

    internal class RegexTokeniserAnonymous2(Matcher matcher) : IPredicate<int> {
        public bool Test(int index)
        {
            return !Objects.IsNull(matcher.Group(index + 1));
        }
    }
}
