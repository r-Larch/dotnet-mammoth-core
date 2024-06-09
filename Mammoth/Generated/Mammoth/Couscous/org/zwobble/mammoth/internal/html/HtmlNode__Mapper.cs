namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface HtmlNode__Mapper<T> {
        T visit(HtmlElement element);
        T visit(HtmlTextNode node);
        T visit(HtmlForceWrite forceWrite);
    }
}
