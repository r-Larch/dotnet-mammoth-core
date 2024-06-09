namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlTextNode(string value) : IXmlNode {
        public string InnerText()
        {
            return value;
        }

        public T Accept<T>(IXmlNodeVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public string GetValue()
        {
            return value;
        }

        public override string ToString()
        {
            return $"XmlTextNode(value={value})";
        }
    }
}
