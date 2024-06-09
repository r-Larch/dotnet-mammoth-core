using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElement {
        private HtmlTag _tag;

        internal HtmlPathElement(HtmlTag tag)
        {
            _tag = tag;
        }

        public ISupplier<IList<IHtmlNode>> Wrap(ISupplier<IList<IHtmlNode>> generateNodes)
        {
            return new HtmlPathElementAnonymous0(this, generateNodes);
        }

        public IList<IHtmlNode> WrapNodes(IList<IHtmlNode> nodes)
        {
            return Lists.List<IHtmlNode>(new HtmlElement(_tag, nodes));
        }
    }
}
