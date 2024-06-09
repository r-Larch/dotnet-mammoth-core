using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlNodes {
        public static XmlElement element(string name)
        {
            return element(name, Lists.list<XmlNode>());
        }

        public static XmlElement element(string name, Map<string, string> attributes)
        {
            return element(name, attributes, Lists.list<XmlNode>());
        }

        public static XmlElement element(string name, List<XmlNode> children)
        {
            return element(name, Maps.map<string, string>(), children);
        }

        public static XmlElement element(string name, Map<string, string> attributes, List<XmlNode> children)
        {
            return new XmlElement(name, attributes, children);
        }

        public static XmlTextNode text(string value)
        {
            return new XmlTextNode(value);
        }
    }
}
