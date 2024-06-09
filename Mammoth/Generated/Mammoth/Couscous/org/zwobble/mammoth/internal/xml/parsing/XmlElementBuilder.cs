using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlElementBuilder {
        private IMap<string, string> _attributes;
        private IList<IXmlNode> _children;
        private string _name;

        internal XmlElementBuilder(string name, IMap<string, string> attributes)
        {
            _name = name;
            _attributes = attributes;
            _children = new ArrayList<IXmlNode>();
        }

        public XmlElement Build()
        {
            return new XmlElement(_name, _attributes, _children);
        }

        public void AddChild(IXmlNode node)
        {
            (_children).Add(node);
        }
    }
}
