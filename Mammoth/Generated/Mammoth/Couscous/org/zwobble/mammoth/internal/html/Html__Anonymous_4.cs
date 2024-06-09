using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_4 : Function<HtmlNode, Optional<HtmlElement>> {
        public Optional<HtmlElement> apply(HtmlNode last)
        {
            return Casts.tryCast<HtmlElement>(typeof(HtmlElement), last);
        }
    }
}
