using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElement {
        internal HtmlTag _tag;

        internal HtmlPathElement(HtmlTag tag)
        {
            _tag = tag;
        }

        public Supplier<List<HtmlNode>> wrap(Supplier<List<HtmlNode>> generateNodes)
        {
            return new HtmlPathElement__Anonymous_0(this, generateNodes);
        }

        public List<HtmlNode> wrapNodes(List<HtmlNode> nodes)
        {
            return Lists.list<HtmlNode>(new HtmlElement(_tag, nodes));
        }
    }
}
