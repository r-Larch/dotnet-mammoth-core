using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.regex;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser {
        public static RegexTokeniser__TokenRule<T> rule<T>(T type, string regex)
        {
            return new RegexTokeniser__TokenRule<T>(type, Pattern.compile(regex));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser<T> {
        internal Pattern _pattern;
        internal List<T> _rules;

        internal RegexTokeniser(T unknown, List<RegexTokeniser__TokenRule<T>> rules)
        {
            List<RegexTokeniser__TokenRule<T>> allRules = new ArrayList<RegexTokeniser__TokenRule<T>>(rules);
            allRules.add(RegexTokeniser.rule(unknown, "."));
            _pattern = Pattern.compile(String.join("|", Iterables.lazyMap(allRules, new RegexTokeniser__Anonymous_0<T>())));
            _rules = Lists.eagerMap(allRules, new RegexTokeniser__Anonymous_1<T>());
        }

        public List<Token<T>> tokenise(string value)
        {
            var matcher = (_pattern).matcher(value);
            List<Token<T>> tokens = new ArrayList<Token<T>>();
            while (matcher.lookingAt()) {
                var groupIndex = Iterables.tryFind(Iterables.intRange(0, (_rules).size()), new RegexTokeniser__Anonymous_2(matcher));
                if (groupIndex.isPresent()) {
                    var tokenType = (_rules).get(groupIndex.get());
                    tokens.add(new Token<T>(matcher.regionStart(), tokenType, matcher.group()));
                    matcher.region(matcher.end(), value.Length);
                }
                else {
                    throw new RuntimeException("Could not find group");
                }
            }

            return tokens;
        }
    }
}
