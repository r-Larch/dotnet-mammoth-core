namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlTextNode : XmlNode {
        internal string _value;

        internal XmlTextNode(string value)
        {
            _value = value;
        }

        public string innerText()
        {
            return _value;
        }

        public T accept<T>(XmlNodeVisitor<T> visitor)
        {
            return visitor.visit(this);
        }

        public string getValue()
        {
            return _value;
        }

        public string toString()
        {
            return ("XmlTextNode(value=" + _value) + ")";
        }
    }
}
