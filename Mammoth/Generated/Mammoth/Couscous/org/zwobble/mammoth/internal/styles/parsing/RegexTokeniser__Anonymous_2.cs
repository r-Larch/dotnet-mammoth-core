namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<int> {
        internal Mammoth.Couscous.java.util.regex.Matcher _matcher;
        internal RegexTokeniser__Anonymous_2(Mammoth.Couscous.java.util.regex.Matcher matcher) {
            this._matcher = matcher;
        }
        public bool test(int index) {
            return !Mammoth.Couscous.java.util.Objects.isNull((this._matcher).group(index + 1));
        }
    }
}

