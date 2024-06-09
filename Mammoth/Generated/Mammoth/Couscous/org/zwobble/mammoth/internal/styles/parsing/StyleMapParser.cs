namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParser {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap parse(string input) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseStyleMappings(Mammoth.Couscous.java.util.Arrays.asList<string>(input.split("\\r?\\n")));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap parseStyleMappings(Mammoth.Couscous.java.util.List<string> lines) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder styleMap = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap.builder();
             {
                int lineIndex = 0;
                while (lineIndex < lines.size()) {
                    string line = lines.get(lineIndex);
                    try {
                        Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.handleLine(styleMap, line);
                    } catch (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException exception) {
                        throw new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.ParseException(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.generateErrorMessage(line, lineIndex + 1, exception.getCharacterIndex(), exception.getMessage()));
                    }
                    lineIndex = lineIndex + 1;
                }
            }
            return styleMap.build();
        }
        public static void handleLine(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder styleMap, string line) {
            if (line.startsWith("#")) {
                return;
            }
            line = line.trim();
            if (line.isEmpty()) {
                return;
            }
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseStyleMapping(line)).accept(styleMap);
        }
        public static Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder> parseStyleMapping(string line) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.tokenise(line);
            Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> documentMatcher = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parse(tokens);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "=>");
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath htmlPath = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseHtmlPath(tokens);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser__Anonymous_0(documentMatcher, htmlPath);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath parseHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY;
            } else {
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parse(tokens);
            }
        }
        public static string generateErrorMessage(string line, int lineNumber, int characterIndex, string message) {
            return ((((((((("error reading style map at line " + lineNumber) + ", character ") + (characterIndex + 1)) + ": ") + message) + "\n\n") + line) + "\n") + Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.repeatString(" ", characterIndex)) + "^";
        }
        public static string repeatString(string value, int times) {
            Mammoth.Couscous.java.lang.StringBuilder builder = new Mammoth.Couscous.java.lang.StringBuilder();
             {
                int i = 0;
                while (i < times) {
                    builder.append(value);
                    i = i + 1;
                }
            }
            return builder.toString();
        }
    }
}

