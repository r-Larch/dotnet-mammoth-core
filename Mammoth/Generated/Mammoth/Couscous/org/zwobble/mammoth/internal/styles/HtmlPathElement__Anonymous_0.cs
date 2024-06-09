using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElementAnonymous0(HtmlPathElement pathElement, ISupplier<IList<IHtmlNode>> generateNodes) : ISupplier<IList<IHtmlNode>> {
        public IList<IHtmlNode> Get()
        {
            return pathElement.WrapNodes(generateNodes.Get());
        }
    }
}
