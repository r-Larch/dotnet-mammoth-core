namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class TokenParser {
        public static Mammoth.Couscous.java.util.Optional<string> parseClassName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ".")) {
                return Mammoth.Couscous.java.util.Optional.of<string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseIdentifier(tokens));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<string>();
            }
        }
        public static string parseIdentifier(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences.decode(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER));
        }
        public static string parseString(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseStringToken(tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING));
        }
        public static string parseStringToken(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> token) {
            string value = token.getValue();
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences.decode(value.Substring(1, ((value.Length) - 1) - 1));
        }
    }
}

