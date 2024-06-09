namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlTextNode : IXmlNode {
        private string _value;

        internal XmlTextNode(string value)
        {
            _value = value;
        }

        public string InnerText()
        {
            return _value;
        }

        public T Accept<T>(IXmlNodeVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public string GetValue()
        {
            return _value;
        }

        public override string ToString()
        {
            return ("XmlTextNode(value=" + _value) + ")";
        }
    }
}
