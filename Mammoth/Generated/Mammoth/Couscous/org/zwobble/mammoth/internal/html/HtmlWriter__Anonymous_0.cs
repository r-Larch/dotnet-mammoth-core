namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter__Anonymous_0 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal HtmlWriter__Anonymous_0(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode child) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.write(child, this._builder);
        }
    }
}

