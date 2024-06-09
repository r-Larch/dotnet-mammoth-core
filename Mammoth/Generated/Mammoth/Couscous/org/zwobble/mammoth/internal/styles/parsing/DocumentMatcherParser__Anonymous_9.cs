using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_9 : BiConsumer<StyleMapBuilder, HtmlPath> {
        private BreakMatcher _breakMatcher;

        internal DocumentMatcherParser__Anonymous_9(BreakMatcher breakMatcher)
        {
            _breakMatcher = breakMatcher;
        }

        public void accept(StyleMapBuilder builder, HtmlPath path)
        {
            builder.mapBreak(_breakMatcher, path);
        }
    }
}
