using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParserAnonymous0 : IConsumer<StyleMapBuilder> {
        private IBiConsumer<StyleMapBuilder, IHtmlPath> _documentMatcher;
        private IHtmlPath _htmlPath;

        internal StyleMapParserAnonymous0(IBiConsumer<StyleMapBuilder, IHtmlPath> documentMatcher, IHtmlPath htmlPath)
        {
            _documentMatcher = documentMatcher;
            _htmlPath = htmlPath;
        }

        public void Accept(StyleMapBuilder styleMap)
        {
            (_documentMatcher).Accept(styleMap, _htmlPath);
        }
    }
}
