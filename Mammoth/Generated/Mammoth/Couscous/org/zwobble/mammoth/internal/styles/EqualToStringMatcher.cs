namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class EqualToStringMatcher : StringMatcher {
        internal string _value;

        internal EqualToStringMatcher(string value)
        {
            _value = value;
        }

        public bool matches(string value)
        {
            return (_value).equalsIgnoreCase(value);
        }
    }
}
