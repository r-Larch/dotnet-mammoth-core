namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlNode {
        string innerText();
        T accept<T>(XmlNodeVisitor<T> visitor);
    }
}
