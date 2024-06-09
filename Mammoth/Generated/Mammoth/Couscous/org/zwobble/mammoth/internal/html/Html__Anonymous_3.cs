namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_3 : HtmlNode__Mapper<HtmlNode> {
        public HtmlNode visit(HtmlElement element)
        {
            return new HtmlElement(element.getTag(), Html.collapse(element.getChildren()));
        }

        public HtmlNode visit(HtmlTextNode node)
        {
            return node;
        }

        public HtmlNode visit(HtmlForceWrite forceWrite)
        {
            return forceWrite;
        }
    }
}
