using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlAnonymous1 : IFunction<IHtmlNode, ITerable<IHtmlNode>> {
        public ITerable<IHtmlNode> Apply(IHtmlNode node)
        {
            return Html.StripEmpty(node);
        }
    }
}
