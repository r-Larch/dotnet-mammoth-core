using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.regex;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser {
        public static RegexTokeniserTokenRule<T> Rule<T>(T type, string regex)
        {
            return new RegexTokeniserTokenRule<T>(type, Pattern.Compile(regex));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser<T> {
        private Pattern _pattern;
        private IList<T> _rules;

        internal RegexTokeniser(T unknown, IList<RegexTokeniserTokenRule<T>> rules)
        {
            IList<RegexTokeniserTokenRule<T>> allRules = new ArrayList<RegexTokeniserTokenRule<T>>(rules);
            allRules.Add(RegexTokeniser.Rule(unknown, "."));
            _pattern = Pattern.Compile(String.Join("|", Iterables.LazyMap(allRules, new RegexTokeniserAnonymous0<T>())));
            _rules = Lists.EagerMap(allRules, new RegexTokeniserAnonymous1<T>());
        }

        public IList<Token<T>> Tokenise(string value)
        {
            var matcher = (_pattern).Matcher(value);
            IList<Token<T>> tokens = new ArrayList<Token<T>>();
            while (matcher.LookingAt()) {
                var groupIndex = Iterables.TryFind(Iterables.IntRange(0, (_rules).Size()), new RegexTokeniserAnonymous2(matcher));
                if (groupIndex.IsPresent()) {
                    var tokenType = (_rules).Get(groupIndex.Get());
                    tokens.Add(new Token<T>(matcher.RegionStart(), tokenType, matcher.Group()));
                    matcher.Region(matcher.End(), value.Length);
                }
                else {
                    throw new RuntimeException("Could not find group");
                }
            }

            return tokens;
        }
    }
}
