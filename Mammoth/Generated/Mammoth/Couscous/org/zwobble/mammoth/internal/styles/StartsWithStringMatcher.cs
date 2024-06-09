using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StartsWithStringMatcher : StringMatcher {
        private string _prefix;

        internal StartsWithStringMatcher(string prefix)
        {
            _prefix = prefix;
        }

        public bool matches(string value)
        {
            return Strings.startsWithIgnoreCase(value, _prefix);
        }
    }
}
