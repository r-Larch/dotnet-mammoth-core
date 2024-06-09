using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElementAnonymous0 : ISupplier<IList<IHtmlNode>> {
        private ISupplier<IList<IHtmlNode>> _generateNodes;
        private HtmlPathElement _thisOrgZwobbleMammothInternalStylesHtmlPathElement;

        internal HtmlPathElementAnonymous0(HtmlPathElement thisOrgZwobbleMammothInternalStylesHtmlPathElement, ISupplier<IList<IHtmlNode>> generateNodes)
        {
            _thisOrgZwobbleMammothInternalStylesHtmlPathElement = thisOrgZwobbleMammothInternalStylesHtmlPathElement;
            _generateNodes = generateNodes;
        }

        public IList<IHtmlNode> Get()
        {
            return (_thisOrgZwobbleMammothInternalStylesHtmlPathElement).WrapNodes((_generateNodes).Get());
        }
    }
}
