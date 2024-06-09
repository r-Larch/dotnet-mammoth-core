using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMappingTokeniser {
        public static TokenIterator<TokenType> Tokenise(string line)
        {
            return new TokenIterator<TokenType>(TokeniseToList(line), new Token<TokenType>(line.Length, TokenType.Eof, ""));
        }

        public static IList<Token<TokenType>> TokeniseToList(string line)
        {
            var stringPrefix = @"'(?:(?:\\.|[^'])*)";
            var identifierCharacter = @"(?:[a-zA-Z\-_]|\\.)";
            var tokeniser = new RegexTokeniser<TokenType>(TokenType.Unknown, Lists.List(RegexTokeniser.Rule(TokenType.Identifier, $"{identifierCharacter}(?:{identifierCharacter}|[0-9])*"), RegexTokeniser.Rule(TokenType.Symbol, ":|>|=>|\\^=|=|\\(|\\)|\\[|\\]|\\||!|\\."), RegexTokeniser.Rule(TokenType.Whitespace, "\\s+"), RegexTokeniser.Rule(TokenType.String, $"{stringPrefix}'"), RegexTokeniser.Rule(TokenType.UnterminatedString, stringPrefix), RegexTokeniser.Rule(TokenType.Integer, "[0-9]+")));
            return tokeniser.Tokenise(line);
        }
    }
}
