namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTextNode : IHtmlNode {
        private string _value;

        internal HtmlTextNode(string value)
        {
            _value = value;
        }

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
            return _value;
        }
    }
}
