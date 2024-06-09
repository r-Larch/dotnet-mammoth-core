using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement : XmlNode, XmlElementLike {
        private Map<string, string> _attributes;
        private List<XmlNode> _children;
        private string _name;

        internal XmlElement(string name, Map<string, string> attributes, List<XmlNode> children)
        {
            _name = name;
            _attributes = attributes;
            _children = children;
        }

        public Optional<string> getAttributeOrNone(string name)
        {
            return Maps.lookup(_attributes, name);
        }

        public List<XmlNode> getChildren()
        {
            return _children;
        }

        public Optional<XmlElement> findChild(string name)
        {
            return Iterables.getFirst(findChildrenIterable(name));
        }

        public bool hasChild(string name)
        {
            return ((findChildrenIterable(name)).iterator()).hasNext();
        }

        public XmlElementLike findChildOrEmpty(string name)
        {
            return Iterables.getFirst(findChildrenIterable(name), NullXmlElement._INSTANCE);
        }

        public string innerText()
        {
            return String.join("", Iterables.lazyMap(_children, new XmlElement__Anonymous_1()));
        }

        public T accept<T>(XmlNodeVisitor<T> visitor)
        {
            return visitor.visit(this);
        }

        public string getName()
        {
            return _name;
        }

        public Map<string, string> getAttributes()
        {
            return _attributes;
        }

        public string getAttribute(string name)
        {
            return (getAttributeOrNone(name)).orElseThrow(new XmlElement__Anonymous_0(name));
        }

        public string toString()
        {
            return ((((("XmlElement(name=" + _name) + ", attributes=") + _attributes) + ", children=") + _children) + ")";
        }

        public XmlElementList findChildren(string name)
        {
            return new XmlElementList(Lists.toList(findChildrenIterable(name)));
        }

        public Iterable<XmlElement> findChildrenIterable(string name)
        {
            return Iterables.lazyFilter(Iterables.lazyFilter<XmlNode, XmlElement>(_children, typeof(XmlElement)), new XmlElement__Anonymous_2(name));
        }
    }
}
