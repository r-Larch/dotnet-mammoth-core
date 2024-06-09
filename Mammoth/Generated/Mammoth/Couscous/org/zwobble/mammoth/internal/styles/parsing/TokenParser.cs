using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class TokenParser {
        public static Optional<string> parseClassName(TokenIterator<TokenType> tokens)
        {
            if (tokens.trySkip(TokenType._SYMBOL, ".")) {
                return Optional.of(parseIdentifier(tokens));
            }

            return Optional.empty<string>();
        }

        public static string parseIdentifier(TokenIterator<TokenType> tokens)
        {
            return EscapeSequences.decode(tokens.nextValue(TokenType._IDENTIFIER));
        }

        public static string parseString(TokenIterator<TokenType> tokens)
        {
            return parseStringToken(tokens.next(TokenType._STRING));
        }

        public static string parseStringToken(Token<TokenType> token)
        {
            var value = token.getValue();
            return EscapeSequences.decode(value.Substring(1, ((value.Length) - 1) - 1));
        }
    }
}
