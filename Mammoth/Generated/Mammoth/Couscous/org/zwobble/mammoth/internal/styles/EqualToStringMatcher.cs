namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class EqualToStringMatcher : IStringMatcher {
        private string _value;

        internal EqualToStringMatcher(string value)
        {
            _value = value;
        }

        public bool Matches(string value)
        {
            return (_value).EqualsIgnoreCase(value);
        }
    }
}
