using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_2 : HtmlNode__Mapper<List<HtmlNode>> {
        public List<HtmlNode> visit(HtmlElement element)
        {
            var children = Html.stripEmpty(element.getChildren());
            if (children.isEmpty() && !element.isVoid()) {
                return Lists.list<HtmlNode>();
            }

            return Lists.list<HtmlNode>(new HtmlElement(element.getTag(), children));
        }

        public List<HtmlNode> visit(HtmlTextNode node)
        {
            if ((node.getValue()).isEmpty()) {
                return Lists.list<HtmlNode>();
            }

            return Lists.list<HtmlNode>(node);
        }

        public List<HtmlNode> visit(HtmlForceWrite forceWrite)
        {
            return Lists.list<HtmlNode>(forceWrite);
        }
    }
}
