using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StartsWithStringMatcher : IStringMatcher {
        private string _prefix;

        internal StartsWithStringMatcher(string prefix)
        {
            _prefix = prefix;
        }

        public bool Matches(string value)
        {
            return Strings.StartsWithIgnoreCase(value, _prefix);
        }
    }
}
