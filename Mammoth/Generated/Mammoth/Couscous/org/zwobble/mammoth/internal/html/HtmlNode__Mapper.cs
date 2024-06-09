namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface IHtmlNodeMapper<T> {
        T Visit(HtmlElement element);
        T Visit(HtmlTextNode node);
        T Visit(HtmlForceWrite forceWrite);
    }
}
