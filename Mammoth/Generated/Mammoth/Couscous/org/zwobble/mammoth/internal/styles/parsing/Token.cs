namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class Token<T>(int characterIndex, T tokenType, string value) {
        public int GetCharacterIndex()
        {
            return characterIndex;
        }

        public T GetTokenType()
        {
            return tokenType;
        }

        public string GetValue()
        {
            return value;
        }

        public override string ToString()
        {
            return $"Token(tokenType={tokenType}, value={value})";
        }
    }
}
