namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_0 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal Html__Anonymous_0(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.write(node, this._builder);
        }
    }
}

