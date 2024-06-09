using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParserAnonymous9 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        private BreakMatcher _breakMatcher;

        internal DocumentMatcherParserAnonymous9(BreakMatcher breakMatcher)
        {
            _breakMatcher = breakMatcher;
        }

        public void Accept(StyleMapBuilder builder, IHtmlPath path)
        {
            builder.MapBreak(_breakMatcher, path);
        }
    }
}
