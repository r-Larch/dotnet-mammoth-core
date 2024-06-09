namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTextNode : HtmlNode {
        internal string _value;

        internal HtmlTextNode(string value)
        {
            _value = value;
        }

        public void accept(HtmlNode__Visitor visitor)
        {
            visitor.visit(this);
        }

        public T accept<T>(HtmlNode__Mapper<T> visitor)
        {
            return visitor.visit(this);
        }

        public string getValue()
        {
            return _value;
        }
    }
}
