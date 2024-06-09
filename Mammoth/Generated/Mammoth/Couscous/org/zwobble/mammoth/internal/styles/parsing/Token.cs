namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class Token {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class Token<T> {
        internal int _characterIndex;
        internal T _tokenType;
        internal string _value;
        internal Token(int characterIndex, T tokenType, string value) {
            this._characterIndex = characterIndex;
            this._tokenType = tokenType;
            this._value = value;
        }
        public int getCharacterIndex() {
            return this._characterIndex;
        }
        public T getTokenType() {
            return this._tokenType;
        }
        public string getValue() {
            return this._value;
        }
        public string toString() {
            return ((("Token(tokenType=" + this._tokenType) + ", value=") + this._value) + ")";
        }
    }
}

