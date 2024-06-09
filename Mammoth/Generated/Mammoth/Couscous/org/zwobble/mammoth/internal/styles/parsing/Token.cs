namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class Token {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class Token<T> {
        private int _characterIndex;
        private T _tokenType;
        private string _value;

        internal Token(int characterIndex, T tokenType, string value)
        {
            _characterIndex = characterIndex;
            _tokenType = tokenType;
            _value = value;
        }

        public int getCharacterIndex()
        {
            return _characterIndex;
        }

        public T getTokenType()
        {
            return _tokenType;
        }

        public string getValue()
        {
            return _value;
        }

        public string toString()
        {
            return ((("Token(tokenType=" + _tokenType) + ", value=") + _value) + ")";
        }
    }
}
