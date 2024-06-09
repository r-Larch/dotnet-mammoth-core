using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NullXmlElement : XmlElementLike {
        internal static XmlElementLike _INSTANCE;

        static NullXmlElement()
        {
            _INSTANCE = new NullXmlElement();
        }

        public bool hasChild(string name)
        {
            return false;
        }

        public Optional<XmlElement> findChild(string name)
        {
            return Optional.empty<XmlElement>();
        }

        public XmlElementLike findChildOrEmpty(string name)
        {
            return this;
        }

        public Optional<string> getAttributeOrNone(string name)
        {
            return Optional.empty<string>();
        }

        public List<XmlNode> getChildren()
        {
            return Lists.list<XmlNode>();
        }
    }
}
