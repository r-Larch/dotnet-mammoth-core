using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface IXmlElementLike {
        bool HasChild(string name);
        IOptional<XmlElement> FindChild(string name);
        IXmlElementLike FindChildOrEmpty(string name);
        IOptional<string> GetAttributeOrNone(string name);
        IList<IXmlNode> GetChildren();
    }
}
