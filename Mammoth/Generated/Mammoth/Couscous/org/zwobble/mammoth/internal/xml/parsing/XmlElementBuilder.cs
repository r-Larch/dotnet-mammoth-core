using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlElementBuilder {
        internal Map<string, string> _attributes;
        internal List<XmlNode> _children;
        internal string _name;

        internal XmlElementBuilder(string name, Map<string, string> attributes)
        {
            _name = name;
            _attributes = attributes;
            _children = new ArrayList<XmlNode>();
        }

        public XmlElement build()
        {
            return new XmlElement(_name, _attributes, _children);
        }

        public void addChild(XmlNode node)
        {
            (_children).add(node);
        }
    }
}
