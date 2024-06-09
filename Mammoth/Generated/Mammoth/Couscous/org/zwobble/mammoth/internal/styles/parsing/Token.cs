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

        public int GetCharacterIndex()
        {
            return _characterIndex;
        }

        public T GetTokenType()
        {
            return _tokenType;
        }

        public string GetValue()
        {
            return _value;
        }

        public override string ToString()
        {
            return ((("Token(tokenType=" + _tokenType) + ", value=") + _value) + ")";
        }
    }
}
