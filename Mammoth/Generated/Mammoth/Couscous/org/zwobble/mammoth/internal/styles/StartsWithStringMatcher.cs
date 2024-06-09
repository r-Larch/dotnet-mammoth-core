using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StartsWithStringMatcher(string prefix) : IStringMatcher {
        public bool Matches(string value)
        {
            return Strings.StartsWithIgnoreCase(value, prefix);
        }
    }
}
