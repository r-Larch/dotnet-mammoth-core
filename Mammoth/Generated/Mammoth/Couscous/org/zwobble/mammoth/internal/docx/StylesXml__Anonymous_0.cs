namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal string _styleType;
        internal StylesXml__Anonymous_0(string styleType) {
            this._styleType = styleType;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement styleElement) {
            return (styleElement.getAttribute("w:type")).Equals(this._styleType);
        }
    }
}

