using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter__Anonymous_1 : HtmlNode__Visitor {
        private StringBuilder _builder;

        internal HtmlWriter__Anonymous_1(StringBuilder builder)
        {
            _builder = builder;
        }

        public void visit(HtmlElement element)
        {
            ((_builder).append("<")).append(element.getTagName());
            HtmlWriter.generateAttributes(element.getAttributes(), _builder);
            if (element.isVoid()) {
                (_builder).append(" />");
            }
            else {
                (_builder).append(">");
                (element.getChildren()).forEach(new HtmlWriter__Anonymous_0(_builder));
                (((_builder).append("</")).append(element.getTagName())).append(">");
            }
        }

        public void visit(HtmlTextNode node)
        {
            (_builder).append(HtmlWriter.escapeText(node.getValue()));
        }

        public void visit(HtmlForceWrite forceWrite)
        {
        }
    }
}
