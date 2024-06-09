namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_2 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.stripEmpty(element.getChildren());
            if (children.isEmpty() && !element.isVoid()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(element.getTag(), children));
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node) {
            if ((node.getValue()).isEmpty()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(node);
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(forceWrite);
        }
    }
}

