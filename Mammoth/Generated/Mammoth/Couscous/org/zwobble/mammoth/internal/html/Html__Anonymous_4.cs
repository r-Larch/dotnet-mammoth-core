using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlAnonymous4 : IFunction<IHtmlNode, IOptional<HtmlElement>> {
        public IOptional<HtmlElement> Apply(IHtmlNode last)
        {
            return Casts.TryCast<HtmlElement>(typeof(HtmlElement), last);
        }
    }
}
