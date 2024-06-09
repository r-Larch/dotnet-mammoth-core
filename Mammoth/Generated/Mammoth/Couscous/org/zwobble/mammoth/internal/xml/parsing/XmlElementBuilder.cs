namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlElementBuilder {
        internal string _name;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> _children;
        internal XmlElementBuilder(string name, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            this._name = name;
            this._attributes = attributes;
            this._children = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(this._name, this._attributes, this._children);
        }
        public void addChild(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode node) {
            (this._children).add(node);
        }
    }
}

