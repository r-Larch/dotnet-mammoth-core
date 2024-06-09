using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous9 : IFunction<IList<IHtmlNode>, string> {
        public string Apply(IList<IHtmlNode> arg0)
        {
            return Html.Write(arg0);
        }
    }
}
