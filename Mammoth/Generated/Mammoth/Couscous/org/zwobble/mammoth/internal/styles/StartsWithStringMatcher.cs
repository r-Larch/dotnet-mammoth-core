namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StartsWithStringMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher {
        internal string _prefix;
        internal StartsWithStringMatcher(string prefix) {
            this._prefix = prefix;
        }
        public bool matches(string value) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.startsWithIgnoreCase(value, this._prefix);
        }
    }
}

