namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class EqualToStringMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher {
        internal string _value;
        internal EqualToStringMatcher(string value) {
            this._value = value;
        }
        public bool matches(string value) {
            return (this._value).equalsIgnoreCase(value);
        }
    }
}

