using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement(string name, IMap<string, string> attributes, IList<IXmlNode> children) : IXmlNode, IXmlElementLike {
        public IOptional<string> GetAttributeOrNone(string name)
        {
            return Maps.Lookup(attributes, name);
        }

        public IList<IXmlNode> GetChildren()
        {
            return children;
        }

        public IOptional<XmlElement> FindChild(string name)
        {
            return Iterables.GetFirst(FindChildrenIterable(name));
        }

        public bool HasChild(string name)
        {
            return FindChildrenIterable(name).Iterator().HasNext();
        }

        public IXmlElementLike FindChildOrEmpty(string name)
        {
            return Iterables.GetFirst(FindChildrenIterable(name), NullXmlElement.Instance);
        }

        public string InnerText()
        {
            return String.Join("", Iterables.LazyMap(children, new XmlElementAnonymous1()));
        }

        public T Accept<T>(IXmlNodeVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public string GetName()
        {
            return name;
        }

        public IMap<string, string> GetAttributes()
        {
            return attributes;
        }

        public string GetAttribute(string name)
        {
            return GetAttributeOrNone(name).OrElseThrow(new XmlElementAnonymous0(name));
        }

        public override string ToString()
        {
            return $"XmlElement(name={name}, attributes={attributes}, children={children})";
        }

        public XmlElementList FindChildren(string name)
        {
            return new XmlElementList(Lists.ToList(FindChildrenIterable(name)));
        }

        public ITerable<XmlElement> FindChildrenIterable(string name)
        {
            return Iterables.LazyFilter(Iterables.LazyFilter<IXmlNode, XmlElement>(children, typeof(XmlElement)), new XmlElementAnonymous2(name));
        }
    }
}
