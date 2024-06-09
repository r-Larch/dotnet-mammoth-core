namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlNode {
        string innerText();
        T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<T> visitor);
    }
}

