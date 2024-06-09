using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous7 : IFunction<IList<IHtmlNode>, IList<IHtmlNode>> {
        public IList<IHtmlNode> Apply(IList<IHtmlNode> arg0)
        {
            return Html.StripEmpty(arg0);
        }
    }
}
