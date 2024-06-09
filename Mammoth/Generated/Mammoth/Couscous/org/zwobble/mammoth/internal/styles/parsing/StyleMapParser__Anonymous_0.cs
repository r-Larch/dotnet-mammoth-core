namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParser__Anonymous_0 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder> {
        internal Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _documentMatcher;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _htmlPath;
        internal StyleMapParser__Anonymous_0(Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> documentMatcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath htmlPath) {
            this._documentMatcher = documentMatcher;
            this._htmlPath = htmlPath;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder styleMap) {
            (this._documentMatcher).accept(styleMap, this._htmlPath);
        }
    }
}

