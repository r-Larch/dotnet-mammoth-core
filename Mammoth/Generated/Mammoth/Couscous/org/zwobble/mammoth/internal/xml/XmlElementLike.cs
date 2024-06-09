namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlElementLike {
        bool hasChild(string name);
        Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChild(string name);
        Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name);
        Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name);
        Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> getChildren();
    }
}

