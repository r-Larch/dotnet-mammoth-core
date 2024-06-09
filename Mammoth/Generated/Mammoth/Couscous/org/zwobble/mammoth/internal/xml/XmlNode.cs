namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface IXmlNode {
        string InnerText();
        T Accept<T>(IXmlNodeVisitor<T> visitor);
    }
}
