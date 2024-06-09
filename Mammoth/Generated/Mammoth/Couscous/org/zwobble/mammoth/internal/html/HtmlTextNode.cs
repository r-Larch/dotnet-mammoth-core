namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTextNode(string value) : IHtmlNode {
        public void Accept(IHtmlNodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public T Accept<T>(IHtmlNodeMapper<T> visitor)
        {
            return visitor.Visit(this);
        }

        public string GetValue()
        {
            return value;
        }
    }
}
