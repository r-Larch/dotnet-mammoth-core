namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlForceWrite : IHtmlNode {
        public static HtmlForceWrite ForceWrite;

        static HtmlForceWrite()
        {
            ForceWrite = new HtmlForceWrite();
        }

        public void Accept(IHtmlNodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public T Accept<T>(IHtmlNodeMapper<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
