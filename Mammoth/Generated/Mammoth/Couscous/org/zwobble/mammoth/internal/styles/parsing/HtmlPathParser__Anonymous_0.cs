namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParserAnonymous0(TokenIterator<TokenType> tokens) : ITokenIteratorAction {
        public void Run()
        {
            tokens.Skip(TokenType.Symbol, ":");
            tokens.Skip(TokenType.Identifier, "fresh");
        }
    }

    internal class HtmlPathParserAnonymous1(TokenIterator<TokenType> tokens) : ITokenIteratorAction {
        public void Run()
        {
            tokens.Skip(TokenType.Symbol, ":");
            tokens.Skip(TokenType.Identifier, "separator");
        }
    }
}
