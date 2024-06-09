using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser {
        public static IHtmlPath Parse(TokenIterator<TokenType> tokens)
        {
            if (tokens.TrySkip(TokenType.Symbol, "!")) {
                return HtmlPathStatic.Ignore;
            }

            return ParseHtmlPathElements(tokens);
        }

        public static IHtmlPath ParseHtmlPathElements(TokenIterator<TokenType> tokens)
        {
            IList<HtmlPathElement> elements = new ArrayList<HtmlPathElement>();
            if (tokens.PeekTokenType() == TokenType.Identifier) {
                var element = ParseElement(tokens);
                elements.Add(element);
                while ((tokens.PeekTokenType() == TokenType.Whitespace) && tokens.IsNext(1, TokenType.Symbol, ">")) {
                    tokens.Skip(TokenType.Whitespace);
                    tokens.Skip(TokenType.Symbol, ">");
                    tokens.Skip(TokenType.Whitespace);
                    elements.Add(ParseElement(tokens));
                }
            }

            return new HtmlPathElements(elements);
        }

        public static HtmlPathElement ParseElement(TokenIterator<TokenType> tokens)
        {
            var tagNames = ParseTagNames(tokens);
            var classNames = ParseClassNames(tokens);
            var attributes = classNames.IsEmpty() ? Maps.Map<string, string>() : Maps.Map("class", String.Join(" ", classNames));
            var isFresh = ParseIsFresh(tokens);
            var separator = ParseSeparator(tokens);
            return new HtmlPathElement(new HtmlTag(tagNames, attributes, !isFresh, separator));
        }

        public static IList<string> ParseTagNames(TokenIterator<TokenType> tokens)
        {
            IList<string> tagNames = new ArrayList<string>();
            tagNames.Add(TokenParser.ParseIdentifier(tokens));
            while (tokens.TrySkip(TokenType.Symbol, "|")) {
                tagNames.Add(TokenParser.ParseIdentifier(tokens));
            }

            return tagNames;
        }

        public static IList<string> ParseClassNames(TokenIterator<TokenType> tokens)
        {
            IList<string> classNames = new ArrayList<string>();
            while (true) {
                var className = TokenParser.ParseClassName(tokens);
                if (className.IsPresent()) {
                    classNames.Add(className.Get());
                }
                else {
                    return classNames;
                }
            }
        }

        public static bool ParseIsFresh(TokenIterator<TokenType> tokens)
        {
            return tokens.TryParse(new HtmlPathParserAnonymous0(tokens));
        }

        public static string ParseSeparator(TokenIterator<TokenType> tokens)
        {
            var isSeparator = tokens.TryParse(new HtmlPathParserAnonymous1(tokens));
            if (isSeparator) {
                tokens.Skip(TokenType.Symbol, "(");
                var value = TokenParser.ParseString(tokens);
                tokens.Skip(TokenType.Symbol, ")");
                return value;
            }

            return "";
        }
    }
}
