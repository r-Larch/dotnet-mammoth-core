using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal interface HtmlPath {
        Supplier<List<HtmlNode>> wrap(Supplier<List<HtmlNode>> generateNodes);
    }
}
