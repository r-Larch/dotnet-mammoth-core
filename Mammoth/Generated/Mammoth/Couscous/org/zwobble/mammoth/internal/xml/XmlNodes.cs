namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlNodes {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element(name, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element(string name, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element(name, attributes, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element(string name, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element(name, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element(string name, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(name, attributes, children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode text(string value) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode(value);
        }
    }
}

