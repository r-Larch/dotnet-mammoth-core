namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_3 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(element.getTag(), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapse(element.getChildren()));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node) {
            return node;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite) {
            return forceWrite;
        }
    }
}

