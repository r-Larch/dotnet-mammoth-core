using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParser__Anonymous_0 : Consumer<StyleMapBuilder> {
        private BiConsumer<StyleMapBuilder, HtmlPath> _documentMatcher;
        private HtmlPath _htmlPath;

        internal StyleMapParser__Anonymous_0(BiConsumer<StyleMapBuilder, HtmlPath> documentMatcher, HtmlPath htmlPath)
        {
            _documentMatcher = documentMatcher;
            _htmlPath = htmlPath;
        }

        public void accept(StyleMapBuilder styleMap)
        {
            (_documentMatcher).accept(styleMap, _htmlPath);
        }
    }
}
