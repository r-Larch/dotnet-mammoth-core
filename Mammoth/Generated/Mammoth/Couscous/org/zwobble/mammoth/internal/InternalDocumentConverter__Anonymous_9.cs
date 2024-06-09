using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_9 : Function<List<HtmlNode>, string> {
        public string apply(List<HtmlNode> arg0)
        {
            return Html.write(arg0);
        }
    }
}
