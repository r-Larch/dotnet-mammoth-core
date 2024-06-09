namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParserAnonymous1 : ITokenIteratorAction {
        private TokenIterator<TokenType> _tokens;

        internal HtmlPathParserAnonymous1(TokenIterator<TokenType> tokens)
        {
            _tokens = tokens;
        }

        public void Run()
        {
            (_tokens).Skip(TokenType.Symbol, ":");
            (_tokens).Skip(TokenType.Identifier, "separator");
        }
    }
}
