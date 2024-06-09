namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlAnonymous3 : IHtmlNodeMapper<IHtmlNode> {
        public IHtmlNode Visit(HtmlElement element)
        {
            return new HtmlElement(element.GetTag(), Html.Collapse(element.GetChildren()));
        }

        public IHtmlNode Visit(HtmlTextNode node)
        {
            return node;
        }

        public IHtmlNode Visit(HtmlForceWrite forceWrite)
        {
            return forceWrite;
        }
    }
}
