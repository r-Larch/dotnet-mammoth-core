using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class LineParseException : RuntimeException {
        private readonly int _characterIndex;

        internal LineParseException(int characterIndex, string message) : base(message)
        {
            _characterIndex = characterIndex;
        }

        internal static LineParseException Create<T>(Token<T> token, string message)
        {
            return new LineParseException(token.GetCharacterIndex(), message);
        }

        internal int GetCharacterIndex()
        {
            return _characterIndex;
        }
    }
}
