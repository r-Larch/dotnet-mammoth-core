using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class TokenParser {
        public static IOptional<string> ParseClassName(TokenIterator<TokenType> tokens)
        {
            if (tokens.TrySkip(TokenType.Symbol, ".")) {
                return Optional.Of(ParseIdentifier(tokens));
            }

            return Optional.Empty<string>();
        }

        public static string ParseIdentifier(TokenIterator<TokenType> tokens)
        {
            return EscapeSequences.Decode(tokens.NextValue(TokenType.Identifier));
        }

        public static string ParseString(TokenIterator<TokenType> tokens)
        {
            return ParseStringToken(tokens.Next(TokenType.String));
        }

        public static string ParseStringToken(Token<TokenType> token)
        {
            var value = token.GetValue();
            return EscapeSequences.Decode(value.Substring(1, value.Length - 1 - 1));
        }
    }
}
