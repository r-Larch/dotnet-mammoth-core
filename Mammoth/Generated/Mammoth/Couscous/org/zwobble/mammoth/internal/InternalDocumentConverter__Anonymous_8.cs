using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_8 : Function<List<HtmlNode>, List<HtmlNode>> {
        public List<HtmlNode> apply(List<HtmlNode> arg0)
        {
            return Html.collapse(arg0);
        }
    }
}
