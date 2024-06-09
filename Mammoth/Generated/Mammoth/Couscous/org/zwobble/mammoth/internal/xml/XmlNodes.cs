using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlNodes {
        public static XmlElement Element(string name)
        {
            return Element(name, Lists.List<IXmlNode>());
        }

        public static XmlElement Element(string name, IMap<string, string> attributes)
        {
            return Element(name, attributes, Lists.List<IXmlNode>());
        }

        public static XmlElement Element(string name, IList<IXmlNode> children)
        {
            return Element(name, Maps.Map<string, string>(), children);
        }

        public static XmlElement Element(string name, IMap<string, string> attributes, IList<IXmlNode> children)
        {
            return new XmlElement(name, attributes, children);
        }

        public static XmlTextNode Text(string value)
        {
            return new XmlTextNode(value);
        }
    }
}
