using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElements : HtmlPath {
        private List<HtmlPathElement> _elements;

        internal HtmlPathElements(List<HtmlPathElement> elements)
        {
            _elements = elements;
        }

        public Supplier<List<HtmlNode>> wrap(Supplier<List<HtmlNode>> generateNodes)
        {
            {
                var _couscous_desugar_foreach_to_for6 = (Lists.reversed(_elements)).iterator();
                while (_couscous_desugar_foreach_to_for6.hasNext()) {
                    var element = _couscous_desugar_foreach_to_for6.next();
                    generateNodes = element.wrap(generateNodes);
                }
            }
            return generateNodes;
        }
    }
}
