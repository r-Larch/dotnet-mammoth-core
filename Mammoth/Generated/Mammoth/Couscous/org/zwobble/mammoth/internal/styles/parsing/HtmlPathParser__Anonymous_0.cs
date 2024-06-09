namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser__Anonymous_0 : TokenIterator__Action {
        private TokenIterator<TokenType> _tokens;

        internal HtmlPathParser__Anonymous_0(TokenIterator<TokenType> tokens)
        {
            _tokens = tokens;
        }

        public void run()
        {
            (_tokens).skip(TokenType._SYMBOL, ":");
            (_tokens).skip(TokenType._IDENTIFIER, "fresh");
        }
    }
}
