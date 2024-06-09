using Mammoth.Couscous.java.math;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser {
        public static BiConsumer<StyleMapBuilder, HtmlPath> parse(TokenIterator<TokenType> tokens)
        {
            var identifier = tokens.next(TokenType._IDENTIFIER);
            switch (identifier.getValue()) {
                case "p":
                    var paragraph = parseParagraphMatcher(tokens);
                    return new DocumentMatcherParser__Anonymous_0(paragraph);
                case "r":
                    var run = parseRunMatcher(tokens);
                    return new DocumentMatcherParser__Anonymous_1(run);
                case "table":
                    var table = parseTableMatcher(tokens);
                    return new DocumentMatcherParser__Anonymous_2(table);
                case "b":
                    return new DocumentMatcherParser__Anonymous_3();
                case "i":
                    return new DocumentMatcherParser__Anonymous_4();
                case "u":
                    return new DocumentMatcherParser__Anonymous_5();
                case "strike":
                    return new DocumentMatcherParser__Anonymous_6();
                case "small-caps":
                    return new DocumentMatcherParser__Anonymous_7();
                case "comment-reference":
                    return new DocumentMatcherParser__Anonymous_8();
                case "br":
                    var breakMatcher = parseBreakMatcher(tokens);
                    return new DocumentMatcherParser__Anonymous_9(breakMatcher);
                default:
                    throw LineParseException.lineParseException(identifier, "Unrecognised document element: " + identifier);
            }
        }

        public static ParagraphMatcher parseParagraphMatcher(TokenIterator<TokenType> tokens)
        {
            var styleId = parseStyleId(tokens);
            var styleName = parseStyleName(tokens);
            var numbering = parseNumbering(tokens);
            return new ParagraphMatcher(styleId, styleName, numbering);
        }

        public static RunMatcher parseRunMatcher(TokenIterator<TokenType> tokens)
        {
            var styleId = parseStyleId(tokens);
            var styleName = parseStyleName(tokens);
            return new RunMatcher(styleId, styleName);
        }

        public static TableMatcher parseTableMatcher(TokenIterator<TokenType> tokens)
        {
            var styleId = parseStyleId(tokens);
            var styleName = parseStyleName(tokens);
            return new TableMatcher(styleId, styleName);
        }

        public static Optional<string> parseStyleId(TokenIterator<TokenType> tokens)
        {
            return TokenParser.parseClassName(tokens);
        }

        public static Optional<StringMatcher> parseStyleName(TokenIterator<TokenType> tokens)
        {
            if (tokens.trySkip(TokenType._SYMBOL, "[")) {
                tokens.skip(TokenType._IDENTIFIER, "style-name");
                var stringMatcher = parseStringMatcher(tokens);
                tokens.skip(TokenType._SYMBOL, "]");
                return Optional.of(stringMatcher);
            }

            return Optional.empty<StringMatcher>();
        }

        public static StringMatcher parseStringMatcher(TokenIterator<TokenType> tokens)
        {
            if (tokens.trySkip(TokenType._SYMBOL, "=")) {
                return new EqualToStringMatcher(TokenParser.parseString(tokens));
            }

            if (tokens.trySkip(TokenType._SYMBOL, "^=")) {
                return new StartsWithStringMatcher(TokenParser.parseString(tokens));
            }

            throw LineParseException.lineParseException(tokens.next(), "Expected string matcher but got token " + (tokens.next()).getValue());
        }

        public static Optional<NumberingLevel> parseNumbering(TokenIterator<TokenType> tokens)
        {
            if (tokens.trySkip(TokenType._SYMBOL, ":")) {
                var isOrdered = parseListType(tokens);
                tokens.skip(TokenType._SYMBOL, "(");
                var level = ((new BigInteger(tokens.nextValue(TokenType._INTEGER))).subtract(BigInteger._ONE)).toString();
                tokens.skip(TokenType._SYMBOL, ")");
                return Optional.of(new NumberingLevel(level, isOrdered));
            }

            return Optional.empty<NumberingLevel>();
        }

        public static bool parseListType(TokenIterator<TokenType> tokens)
        {
            var listType = tokens.next(TokenType._IDENTIFIER);
            switch (listType.getValue()) {
                case "ordered-list":
                    return true;
                case "unordered-list":
                    return false;
                default:
                    throw LineParseException.lineParseException(listType, "Unrecognised list type: " + listType);
            }
        }

        public static BreakMatcher parseBreakMatcher(TokenIterator<TokenType> tokens)
        {
            tokens.skip(TokenType._SYMBOL, "[");
            tokens.skip(TokenType._IDENTIFIER, "type");
            tokens.skip(TokenType._SYMBOL, "=");
            var stringToken = tokens.next(TokenType._STRING);
            tokens.skip(TokenType._SYMBOL, "]");
            var typeName = TokenParser.parseStringToken(stringToken);
            switch (typeName) {
                case "line":
                    return BreakMatcher._LINE_BREAK;
                case "page":
                    return BreakMatcher._PAGE_BREAK;
                case "column":
                    return BreakMatcher._COLUMN_BREAK;
                default:
                    throw LineParseException.lineParseException(stringToken, "Unrecognised break type: " + typeName);
            }
        }
    }
}
