namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T> rule<T>(T type, string regex) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>(type, Mammoth.Couscous.java.util.regex.Pattern.compile(regex));
        }
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser<T> {
        internal Mammoth.Couscous.java.util.regex.Pattern _pattern;
        internal Mammoth.Couscous.java.util.List<T> _rules;
        internal RegexTokeniser(T unknown, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>> rules) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>> allRules = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>>(rules);
            allRules.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<T>(unknown, "."));
            this._pattern = Mammoth.Couscous.java.util.regex.Pattern.compile(java.lang.String.join("|", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>, string>(allRules, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__Anonymous_0<T>())));
            this._rules = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>, T>(allRules, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__Anonymous_1<T>());
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> tokenise(string value) {
            Mammoth.Couscous.java.util.regex.Matcher matcher = (this._pattern).matcher(value);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> tokens = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>>();
            while (matcher.lookingAt()) {
                Mammoth.Couscous.java.util.Optional<int> groupIndex = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<int>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.intRange(0, (this._rules).size()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__Anonymous_2(matcher));
                if (groupIndex.isPresent()) {
                    T tokenType = (this._rules).get(groupIndex.get());
                    tokens.add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>(matcher.regionStart(), tokenType, matcher.group()));
                    matcher.region(matcher.end(), value.Length);
                } else {
                    throw new Mammoth.Couscous.java.lang.RuntimeException("Could not find group");
                }
            }
            return tokens;
        }
    }
}

