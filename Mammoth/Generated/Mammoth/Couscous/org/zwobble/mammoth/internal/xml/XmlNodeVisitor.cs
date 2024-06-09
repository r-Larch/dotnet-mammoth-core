namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlNodeVisitor<T> {
        T visit(XmlElement element);
        T visit(XmlTextNode textNode);
    }
}
