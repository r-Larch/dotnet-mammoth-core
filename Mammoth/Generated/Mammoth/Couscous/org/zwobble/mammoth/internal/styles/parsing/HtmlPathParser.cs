namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath parse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "!")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._IGNORE;
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseHtmlPathElements(tokens);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath parseHtmlPathElements(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> elements = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>();
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement element = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseElement(tokens);
                elements.add(element);
                while ((tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE) && tokens.isNext(1, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ">")) {
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ">");
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                    elements.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseElement(tokens));
                }
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(elements);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement parseElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<string> tagNames = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseTagNames(tokens);
            Mammoth.Couscous.java.util.List<string> classNames = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseClassNames(tokens);
            Mammoth.Couscous.java.util.Map<string, string> attributes = classNames.isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("class", java.lang.String.join(" ", classNames));
            bool isFresh = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseIsFresh(tokens);
            string separator = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseSeparator(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(tagNames, attributes, !isFresh, separator));
        }
        public static Mammoth.Couscous.java.util.List<string> parseTagNames(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<string> tagNames = new Mammoth.Couscous.java.util.ArrayList<string>();
            tagNames.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseIdentifier(tokens));
            while (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "|")) {
                tagNames.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseIdentifier(tokens));
            }
            return tagNames;
        }
        public static Mammoth.Couscous.java.util.List<string> parseClassNames(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<string> classNames = new Mammoth.Couscous.java.util.ArrayList<string>();
            while (true) {
                Mammoth.Couscous.java.util.Optional<string> className = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseClassName(tokens);
                if (className.isPresent()) {
                    classNames.add(className.get());
                } else {
                    return classNames;
                }
            }
        }
        public static bool parseIsFresh(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            return tokens.tryParse(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Anonymous_0(tokens));
        }
        public static string parseSeparator(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            bool isSeparator = tokens.tryParse(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Anonymous_1(tokens));
            if (isSeparator) {
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "(");
                string value = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseString(tokens);
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ")");
                return value;
            } else {
                return "";
            }
        }
    }
}

