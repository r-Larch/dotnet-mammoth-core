using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_1 : Function<HtmlNode, Iterable<HtmlNode>> {
        public Iterable<HtmlNode> apply(HtmlNode node)
        {
            return Html.stripEmpty(node);
        }
    }
}
