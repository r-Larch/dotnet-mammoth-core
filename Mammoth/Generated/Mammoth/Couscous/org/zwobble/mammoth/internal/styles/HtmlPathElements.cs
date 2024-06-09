using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElements(IList<HtmlPathElement> elements) : IHtmlPath {
        public ISupplier<IList<IHtmlNode>> Wrap(ISupplier<IList<IHtmlNode>> generateNodes)
        {
            {
                var couscousDesugarForeachToFor6 = Lists.Reversed(elements).Iterator();
                while (couscousDesugarForeachToFor6.HasNext()) {
                    var element = couscousDesugarForeachToFor6.Next();
                    generateNodes = element.Wrap(generateNodes);
                }
            }
            return generateNodes;
        }
    }
}
