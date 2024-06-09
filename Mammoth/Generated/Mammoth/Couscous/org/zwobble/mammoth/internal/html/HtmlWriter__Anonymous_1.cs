namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal HtmlWriter__Anonymous_1(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            ((this._builder).append("<")).append(element.getTagName());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.generateAttributes(element.getAttributes(), this._builder);
            if (element.isVoid()) {
                (this._builder).append(" />");
            } else {
                (this._builder).append(">");
                (element.getChildren()).forEach(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter__Anonymous_0(this._builder));
                (((this._builder).append("</")).append(element.getTagName())).append(">");
            }
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node) {
            (this._builder).append(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.escapeText(node.getValue()));
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite) {
        }
    }
}

