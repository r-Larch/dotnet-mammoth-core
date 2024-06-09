namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElement__Anonymous_0 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement _this_org__zwobble__mammoth__internal__styles__HtmlPathElement;
        internal Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> _generateNodes;
        internal HtmlPathElement__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement this_org__zwobble__mammoth__internal__styles__HtmlPathElement, Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> generateNodes) {
            this._this_org__zwobble__mammoth__internal__styles__HtmlPathElement = this_org__zwobble__mammoth__internal__styles__HtmlPathElement;
            this._generateNodes = generateNodes;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return (this._this_org__zwobble__mammoth__internal__styles__HtmlPathElement).wrapNodes((this._generateNodes).get());
        }
    }
}

