namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NullXmlElement : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _INSTANCE;
        static NullXmlElement() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NullXmlElement._INSTANCE = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NullXmlElement();
        }
        public bool hasChild(string name) {
            return false;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChild(string name) {
            return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name) {
            return this;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name) {
            return Mammoth.Couscous.java.util.Optional.empty<string>();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> getChildren() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>();
        }
    }
}

