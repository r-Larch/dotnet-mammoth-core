namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlTextNode : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode {
        internal string _value;
        internal XmlTextNode(string value) {
            this._value = value;
        }
        public string getValue() {
            return this._value;
        }
        public string innerText() {
            return this._value;
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<T> visitor) {
            return visitor.visit(this);
        }
        public string toString() {
            return ("XmlTextNode(value=" + this._value) + ")";
        }
    }
}

