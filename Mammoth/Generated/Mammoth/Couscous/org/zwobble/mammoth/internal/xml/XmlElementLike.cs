using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlElementLike {
        bool hasChild(string name);
        Optional<XmlElement> findChild(string name);
        XmlElementLike findChildOrEmpty(string name);
        Optional<string> getAttributeOrNone(string name);
        List<XmlNode> getChildren();
    }
}
