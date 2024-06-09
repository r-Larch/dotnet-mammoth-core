using Mammoth.Couscous.java.math;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser {
        public static IBiConsumer<StyleMapBuilder, IHtmlPath> Parse(TokenIterator<TokenType> tokens)
        {
            var identifier = tokens.Next(TokenType.Identifier);
            switch (identifier.GetValue()) {
                case "p":
                    var paragraph = ParseParagraphMatcher(tokens);
                    return new DocumentMatcherParserAnonymous0(paragraph);
                case "r":
                    var run = ParseRunMatcher(tokens);
                    return new DocumentMatcherParserAnonymous1(run);
                case "table":
                    var table = ParseTableMatcher(tokens);
                    return new DocumentMatcherParserAnonymous2(table);
                case "b":
                    return new DocumentMatcherParserAnonymous3();
                case "i":
                    return new DocumentMatcherParserAnonymous4();
                case "u":
                    return new DocumentMatcherParserAnonymous5();
                case "strike":
                    return new DocumentMatcherParserAnonymous6();
                case "small-caps":
                    return new DocumentMatcherParserAnonymous7();
                case "comment-reference":
                    return new DocumentMatcherParserAnonymous8();
                case "br":
                    var breakMatcher = ParseBreakMatcher(tokens);
                    return new DocumentMatcherParserAnonymous9(breakMatcher);
                default:
                    throw LineParseException.Create(identifier, $"Unrecognised document element: {identifier}");
            }
        }

        public static ParagraphMatcher ParseParagraphMatcher(TokenIterator<TokenType> tokens)
        {
            var styleId = ParseStyleId(tokens);
            var styleName = ParseStyleName(tokens);
            var numbering = ParseNumbering(tokens);
            return new ParagraphMatcher(styleId, styleName, numbering);
        }

        public static RunMatcher ParseRunMatcher(TokenIterator<TokenType> tokens)
        {
            var styleId = ParseStyleId(tokens);
            var styleName = ParseStyleName(tokens);
            return new RunMatcher(styleId, styleName);
        }

        public static TableMatcher ParseTableMatcher(TokenIterator<TokenType> tokens)
        {
            var styleId = ParseStyleId(tokens);
            var styleName = ParseStyleName(tokens);
            return new TableMatcher(styleId, styleName);
        }

        public static IOptional<string> ParseStyleId(TokenIterator<TokenType> tokens)
        {
            return TokenParser.ParseClassName(tokens);
        }

        public static IOptional<IStringMatcher> ParseStyleName(TokenIterator<TokenType> tokens)
        {
            if (tokens.TrySkip(TokenType.Symbol, "[")) {
                tokens.Skip(TokenType.Identifier, "style-name");
                var stringMatcher = ParseStringMatcher(tokens);
                tokens.Skip(TokenType.Symbol, "]");
                return Optional.Of(stringMatcher);
            }

            return Optional.Empty<IStringMatcher>();
        }

        public static IStringMatcher ParseStringMatcher(TokenIterator<TokenType> tokens)
        {
            if (tokens.TrySkip(TokenType.Symbol, "=")) {
                return new EqualToStringMatcher(TokenParser.ParseString(tokens));
            }

            if (tokens.TrySkip(TokenType.Symbol, "^=")) {
                return new StartsWithStringMatcher(TokenParser.ParseString(tokens));
            }

            throw LineParseException.Create(tokens.Next(), $"Expected string matcher but got token {tokens.Next().GetValue()}");
        }

        public static IOptional<NumberingLevel> ParseNumbering(TokenIterator<TokenType> tokens)
        {
            if (tokens.TrySkip(TokenType.Symbol, ":")) {
                var isOrdered = ParseListType(tokens);
                tokens.Skip(TokenType.Symbol, "(");
                var level = new BigInteger(tokens.NextValue(TokenType.Integer)).Subtract(BigInteger.One).ToString();
                tokens.Skip(TokenType.Symbol, ")");
                return Optional.Of(new NumberingLevel(level, isOrdered));
            }

            return Optional.Empty<NumberingLevel>();
        }

        public static bool ParseListType(TokenIterator<TokenType> tokens)
        {
            var listType = tokens.Next(TokenType.Identifier);
            return listType.GetValue() switch {
                "ordered-list" => true,
                "unordered-list" => false,
                _ => throw LineParseException.Create(listType, $"Unrecognised list type: {listType}")
            };
        }

        public static BreakMatcher ParseBreakMatcher(TokenIterator<TokenType> tokens)
        {
            tokens.Skip(TokenType.Symbol, "[");
            tokens.Skip(TokenType.Identifier, "type");
            tokens.Skip(TokenType.Symbol, "=");
            var stringToken = tokens.Next(TokenType.String);
            tokens.Skip(TokenType.Symbol, "]");
            var typeName = TokenParser.ParseStringToken(stringToken);
            return typeName switch {
                "line" => BreakMatcher.LineBreak,
                "page" => BreakMatcher.PageBreak,
                "column" => BreakMatcher.ColumnBreak,
                _ => throw LineParseException.Create(stringToken, $"Unrecognised break type: {typeName}")
            };
        }
    }
}
