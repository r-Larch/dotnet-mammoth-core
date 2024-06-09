using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NullXmlElement : IXmlElementLike {
        public static IXmlElementLike Instance;

        static NullXmlElement()
        {
            Instance = new NullXmlElement();
        }

        public bool HasChild(string name)
        {
            return false;
        }

        public IOptional<XmlElement> FindChild(string name)
        {
            return Optional.Empty<XmlElement>();
        }

        public IXmlElementLike FindChildOrEmpty(string name)
        {
            return this;
        }

        public IOptional<string> GetAttributeOrNone(string name)
        {
            return Optional.Empty<string>();
        }

        public IList<IXmlNode> GetChildren()
        {
            return Lists.List<IXmlNode>();
        }
    }
}
