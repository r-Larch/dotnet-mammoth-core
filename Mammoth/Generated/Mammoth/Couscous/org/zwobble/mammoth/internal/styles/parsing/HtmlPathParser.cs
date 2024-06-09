using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser {
        public static HtmlPath parse(TokenIterator<TokenType> tokens)
        {
            if (tokens.trySkip(TokenType._SYMBOL, "!")) {
                return HtmlPath_static._IGNORE;
            }

            return parseHtmlPathElements(tokens);
        }

        public static HtmlPath parseHtmlPathElements(TokenIterator<TokenType> tokens)
        {
            List<HtmlPathElement> elements = new ArrayList<HtmlPathElement>();
            if (tokens.peekTokenType() == TokenType._IDENTIFIER) {
                var element = parseElement(tokens);
                elements.add(element);
                while ((tokens.peekTokenType() == TokenType._WHITESPACE) && tokens.isNext(1, TokenType._SYMBOL, ">")) {
                    tokens.skip(TokenType._WHITESPACE);
                    tokens.skip(TokenType._SYMBOL, ">");
                    tokens.skip(TokenType._WHITESPACE);
                    elements.add(parseElement(tokens));
                }
            }

            return new HtmlPathElements(elements);
        }

        public static HtmlPathElement parseElement(TokenIterator<TokenType> tokens)
        {
            var tagNames = parseTagNames(tokens);
            var classNames = parseClassNames(tokens);
            var attributes = classNames.isEmpty() ? Maps.map<string, string>() : Maps.map("class", String.join(" ", classNames));
            var isFresh = parseIsFresh(tokens);
            var separator = parseSeparator(tokens);
            return new HtmlPathElement(new HtmlTag(tagNames, attributes, !isFresh, separator));
        }

        public static List<string> parseTagNames(TokenIterator<TokenType> tokens)
        {
            List<string> tagNames = new ArrayList<string>();
            tagNames.add(TokenParser.parseIdentifier(tokens));
            while (tokens.trySkip(TokenType._SYMBOL, "|")) {
                tagNames.add(TokenParser.parseIdentifier(tokens));
            }

            return tagNames;
        }

        public static List<string> parseClassNames(TokenIterator<TokenType> tokens)
        {
            List<string> classNames = new ArrayList<string>();
            while (true) {
                var className = TokenParser.parseClassName(tokens);
                if (className.isPresent()) {
                    classNames.add(className.get());
                }
                else {
                    return classNames;
                }
            }
        }

        public static bool parseIsFresh(TokenIterator<TokenType> tokens)
        {
            return tokens.tryParse(new HtmlPathParser__Anonymous_0(tokens));
        }

        public static string parseSeparator(TokenIterator<TokenType> tokens)
        {
            var isSeparator = tokens.tryParse(new HtmlPathParser__Anonymous_1(tokens));
            if (isSeparator) {
                tokens.skip(TokenType._SYMBOL, "(");
                var value = TokenParser.parseString(tokens);
                tokens.skip(TokenType._SYMBOL, ")");
                return value;
            }

            return "";
        }
    }
}
