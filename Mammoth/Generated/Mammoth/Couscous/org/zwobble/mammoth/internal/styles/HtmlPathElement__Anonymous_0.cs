using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElement__Anonymous_0 : Supplier<List<HtmlNode>> {
        internal Supplier<List<HtmlNode>> _generateNodes;
        internal HtmlPathElement _this_org__zwobble__mammoth__internal__styles__HtmlPathElement;

        internal HtmlPathElement__Anonymous_0(HtmlPathElement this_org__zwobble__mammoth__internal__styles__HtmlPathElement, Supplier<List<HtmlNode>> generateNodes)
        {
            _this_org__zwobble__mammoth__internal__styles__HtmlPathElement = this_org__zwobble__mammoth__internal__styles__HtmlPathElement;
            _generateNodes = generateNodes;
        }

        public List<HtmlNode> get()
        {
            return (_this_org__zwobble__mammoth__internal__styles__HtmlPathElement).wrapNodes((_generateNodes).get());
        }
    }
}
