using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlAnonymous2 : IHtmlNodeMapper<IList<IHtmlNode>> {
        public IList<IHtmlNode> Visit(HtmlElement element)
        {
            var children = Html.StripEmpty(element.GetChildren());
            if (children.IsEmpty() && !element.IsVoid()) {
                return Lists.List<IHtmlNode>();
            }

            return Lists.List<IHtmlNode>(new HtmlElement(element.GetTag(), children));
        }

        public IList<IHtmlNode> Visit(HtmlTextNode node)
        {
            if ((node.GetValue()).IsEmpty()) {
                return Lists.List<IHtmlNode>();
            }

            return Lists.List<IHtmlNode>(node);
        }

        public IList<IHtmlNode> Visit(HtmlForceWrite forceWrite)
        {
            return Lists.List<IHtmlNode>(forceWrite);
        }
    }
}
