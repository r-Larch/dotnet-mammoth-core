using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParser {
        public static StyleMap parse(string input)
        {
            return parseStyleMappings(Arrays.asList(input.split("\\r?\\n")));
        }

        public static StyleMap parseStyleMappings(List<string> lines)
        {
            var styleMap = StyleMap.builder();
            {
                var lineIndex = 0;
                while (lineIndex < lines.size()) {
                    var line = lines.get(lineIndex);
                    try {
                        handleLine(styleMap, line);
                    }
                    catch (LineParseException exception) {
                        throw new ParseException(generateErrorMessage(line, lineIndex + 1, exception.getCharacterIndex(), exception.getMessage()));
                    }

                    lineIndex = lineIndex + 1;
                }
            }
            return styleMap.build();
        }

        public static void handleLine(StyleMapBuilder styleMap, string line)
        {
            if (line.startsWith("#")) {
                return;
            }

            line = line.trim();
            if (line.isEmpty()) {
                return;
            }

            (parseStyleMapping(line)).accept(styleMap);
        }

        public static Consumer<StyleMapBuilder> parseStyleMapping(string line)
        {
            var tokens = StyleMappingTokeniser.tokenise(line);
            var documentMatcher = DocumentMatcherParser.parse(tokens);
            tokens.skip(TokenType._WHITESPACE);
            tokens.skip(TokenType._SYMBOL, "=>");
            var htmlPath = parseHtmlPath(tokens);
            tokens.skip(TokenType._EOF);
            return new StyleMapParser__Anonymous_0(documentMatcher, htmlPath);
        }

        public static HtmlPath parseHtmlPath(TokenIterator<TokenType> tokens)
        {
            if (tokens.peekTokenType() == TokenType._EOF) {
                return HtmlPath_static._EMPTY;
            }

            tokens.skip(TokenType._WHITESPACE);
            return HtmlPathParser.parse(tokens);
        }

        public static string generateErrorMessage(string line, int lineNumber, int characterIndex, string message)
        {
            return ((((((((("error reading style map at line " + lineNumber) + ", character ") + (characterIndex + 1)) + ": ") + message) + "\n\n") + line) + "\n") + repeatString(" ", characterIndex)) + "^";
        }

        public static string repeatString(string value, int times)
        {
            var builder = new StringBuilder();
            {
                var i = 0;
                while (i < times) {
                    builder.append(value);
                    i = i + 1;
                }
            }
            return builder.toString();
        }
    }
}
