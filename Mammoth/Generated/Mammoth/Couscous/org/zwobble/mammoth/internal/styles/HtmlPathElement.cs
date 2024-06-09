namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElement {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag _tag;
        internal HtmlPathElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag tag) {
            this._tag = tag;
        }
        public Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> wrap(Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> generateNodes) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement__Anonymous_0(this, generateNodes);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> wrapNodes(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(this._tag, nodes));
        }
    }
}

