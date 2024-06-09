namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser {
        public static Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> parse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> identifier = tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER);
            switch (identifier.getValue()) {
                case "p":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher paragraph = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseParagraphMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_0(paragraph);
                case "r":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher run = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseRunMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_1(run);
                case "table":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher table = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseTableMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_2(table);
                case "b":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_3();
                case "i":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_4();
                case "u":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_5();
                case "strike":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_6();
                case "small-caps":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_7();
                case "comment-reference":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_8();
                case "br":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher breakMatcher = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseBreakMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_9(breakMatcher);
                default:
                    throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(identifier, "Unrecognised document element: " + identifier);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher parseParagraphMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.Optional<string> styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleId(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleName(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseNumbering(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(styleId, styleName, numbering);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher parseRunMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.Optional<string> styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleId(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleName(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(styleId, styleName);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher parseTableMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.Optional<string> styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleId(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleName(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher(styleId, styleName);
        }
        public static Mammoth.Couscous.java.util.Optional<string> parseStyleId(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseClassName(tokens);
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> parseStyleName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "[")) {
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "style-name");
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher stringMatcher = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStringMatcher(tokens);
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "]");
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(stringMatcher);
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>();
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher parseStringMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "=")) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.EqualToStringMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseString(tokens));
            } else if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "^=")) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StartsWithStringMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseString(tokens));
            } else {
                throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(tokens.next(), "Expected string matcher but got token " + (tokens.next()).getValue());
            }
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> parseNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ":")) {
                bool isOrdered = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseListType(tokens);
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "(");
                string level = ((new Mammoth.Couscous.java.math.BigInteger(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._INTEGER))).subtract(Mammoth.Couscous.java.math.BigInteger._ONE)).toString();
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ")");
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(level, isOrdered));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>();
            }
        }
        public static bool parseListType(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> listType = tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER);
            switch (listType.getValue()) {
                case "ordered-list":
                    return true;
                case "unordered-list":
                    return false;
                default:
                    throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(listType, "Unrecognised list type: " + listType);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher parseBreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "[");
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "type");
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "=");
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> stringToken = tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "]");
            string typeName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseStringToken(stringToken);
            switch (typeName) {
                case "line":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._LINE_BREAK;
                case "page":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._PAGE_BREAK;
                case "column":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._COLUMN_BREAK;
                default:
                    throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(stringToken, "Unrecognised break type: " + typeName);
            }
        }
    }
}

