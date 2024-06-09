namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface IHtmlNode {
        void Accept(IHtmlNodeVisitor visitor);
        T Accept<T>(IHtmlNodeMapper<T> visitor);
    }
}
