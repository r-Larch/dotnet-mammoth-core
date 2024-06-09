namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class EqualToStringMatcher(string value) : IStringMatcher {
        public bool Matches(string value1)
        {
            return value.EqualsIgnoreCase(value1);
        }
    }
}
