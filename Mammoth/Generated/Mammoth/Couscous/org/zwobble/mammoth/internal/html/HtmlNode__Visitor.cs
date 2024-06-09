namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface IHtmlNodeVisitor {
        void Visit(HtmlElement element);
        void Visit(HtmlTextNode node);
        void Visit(HtmlForceWrite forceWrite);
    }
}
