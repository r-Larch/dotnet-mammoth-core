namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, bool> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal string _identifyingAttribute;
        internal EmbeddedStyleMap__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, string identifyingAttribute) {
            this._element = element;
            this._identifyingAttribute = identifyingAttribute;
        }
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement childElement) {
            return ((childElement.getName()).Equals((this._element).getName())) && (childElement.getAttributeOrNone(this._identifyingAttribute)).equals((this._element).getAttributeOrNone(this._identifyingAttribute));
        }
    }
}

