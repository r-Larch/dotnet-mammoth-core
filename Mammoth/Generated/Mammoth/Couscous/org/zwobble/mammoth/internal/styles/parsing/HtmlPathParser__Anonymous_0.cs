namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParserAnonymous0 : ITokenIteratorAction {
        private TokenIterator<TokenType> _tokens;

        internal HtmlPathParserAnonymous0(TokenIterator<TokenType> tokens)
        {
            _tokens = tokens;
        }

        public void Run()
        {
            (_tokens).Skip(TokenType.Symbol, ":");
            (_tokens).Skip(TokenType.Identifier, "fresh");
        }
    }
}
