namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface IXmlNodeVisitor<out T> {
        T Visit(XmlElement element);
        T Visit(XmlTextNode textNode);
    }
}
