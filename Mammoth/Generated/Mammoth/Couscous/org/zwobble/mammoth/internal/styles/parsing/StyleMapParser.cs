using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParser {
        public static StyleMap Parse(string input)
        {
            return ParseStyleMappings(Arrays.AsList(JavaStringExtensions.Split(input, "\\r?\\n")));
        }

        public static StyleMap ParseStyleMappings(IList<string> lines)
        {
            var styleMap = StyleMap.Builder();
            {
                var lineIndex = 0;
                while (lineIndex < lines.Size()) {
                    var line = lines.Get(lineIndex);
                    try {
                        HandleLine(styleMap, line);
                    }
                    catch (LineParseException exception) {
                        throw new ParseException(GenerateErrorMessage(line, lineIndex + 1, exception.GetCharacterIndex(), exception.Message));
                    }

                    lineIndex = lineIndex + 1;
                }
            }
            return styleMap.Build();
        }

        public static void HandleLine(StyleMapBuilder styleMap, string line)
        {
            if (JavaStringExtensions.StartsWith(line, "#")) {
                return;
            }

            line = JavaStringExtensions.Trim(line);
            if (line.IsEmpty()) {
                return;
            }

            (ParseStyleMapping(line)).Accept(styleMap);
        }

        public static IConsumer<StyleMapBuilder> ParseStyleMapping(string line)
        {
            var tokens = StyleMappingTokeniser.Tokenise(line);
            var documentMatcher = DocumentMatcherParser.Parse(tokens);
            tokens.Skip(TokenType.Whitespace);
            tokens.Skip(TokenType.Symbol, "=>");
            var htmlPath = ParseHtmlPath(tokens);
            tokens.Skip(TokenType.Eof);
            return new StyleMapParserAnonymous0(documentMatcher, htmlPath);
        }

        public static IHtmlPath ParseHtmlPath(TokenIterator<TokenType> tokens)
        {
            if (tokens.PeekTokenType() == TokenType.Eof) {
                return HtmlPathStatic.Empty;
            }

            tokens.Skip(TokenType.Whitespace);
            return HtmlPathParser.Parse(tokens);
        }

        public static string GenerateErrorMessage(string line, int lineNumber, int characterIndex, string message)
        {
            return ((((((((("error reading style map at line " + lineNumber) + ", character ") + (characterIndex + 1)) + ": ") + message) + "\n\n") + line) + "\n") + RepeatString(" ", characterIndex)) + "^";
        }

        public static string RepeatString(string value, int times)
        {
            var builder = new StringBuilder();
            {
                var i = 0;
                while (i < times) {
                    builder.Append(value);
                    i = i + 1;
                }
            }
            return builder.ToString();
        }
    }
}
