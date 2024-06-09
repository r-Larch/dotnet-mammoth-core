namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElements : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> _elements;
        internal HtmlPathElements(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> elements) {
            this._elements = elements;
        }
        public Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> wrap(Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> generateNodes) {
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> _couscous_desugar_foreach_to_for6 = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.reversed<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(this._elements)).iterator();
                while (_couscous_desugar_foreach_to_for6.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement element = _couscous_desugar_foreach_to_for6.next();
                    generateNodes = element.wrap(generateNodes);
                }
            }
            return generateNodes;
        }
    }
}

