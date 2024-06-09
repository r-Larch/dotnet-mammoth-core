using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMappingTokeniser {
        public static TokenIterator<TokenType> tokenise(string line)
        {
            return new TokenIterator<TokenType>(tokeniseToList(line), new Token<TokenType>(line.Length, TokenType._EOF, ""));
        }

        public static List<Token<TokenType>> tokeniseToList(string line)
        {
            var stringPrefix = "'(?:(?:\\\\.|[^'])*)";
            var identifierCharacter = "(?:[a-zA-Z\\-_]|\\\\.)";
            var tokeniser = new RegexTokeniser<TokenType>(TokenType._UNKNOWN, Lists.list(RegexTokeniser.rule(TokenType._IDENTIFIER, ((identifierCharacter + "(?:") + identifierCharacter) + "|[0-9])*"), RegexTokeniser.rule(TokenType._SYMBOL, ":|>|=>|\\^=|=|\\(|\\)|\\[|\\]|\\||!|\\."), RegexTokeniser.rule(TokenType._WHITESPACE, "\\s+"), RegexTokeniser.rule(TokenType._STRING, stringPrefix + "'"), RegexTokeniser.rule(TokenType._UNTERMINATED_STRING, stringPrefix), RegexTokeniser.rule(TokenType._INTEGER, "[0-9]+")));
            return tokeniser.tokenise(line);
        }
    }
}
