using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlElementBuilder(string name, IMap<string, string> attributes) {
        private readonly IList<IXmlNode> _children = new ArrayList<IXmlNode>();

        public XmlElement Build()
        {
            return new XmlElement(name, attributes, _children);
        }

        public void AddChild(IXmlNode node)
        {
            _children.Add(node);
        }
    }
}
