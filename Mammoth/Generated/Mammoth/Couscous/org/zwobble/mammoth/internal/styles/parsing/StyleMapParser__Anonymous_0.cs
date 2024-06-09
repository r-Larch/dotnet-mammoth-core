using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParserAnonymous0(IBiConsumer<StyleMapBuilder, IHtmlPath> documentMatcher, IHtmlPath htmlPath) : IConsumer<StyleMapBuilder> {
        public void Accept(StyleMapBuilder styleMap)
        {
            documentMatcher.Accept(styleMap, htmlPath);
        }
    }
}
