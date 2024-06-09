namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal string _identifyingAttribute;
        internal EmbeddedStyleMap__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, string identifyingAttribute) {
            this._element = element;
            this._identifyingAttribute = identifyingAttribute;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode child) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement), child)).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap__Anonymous_1(this._element, this._identifyingAttribute))).orElse(false);
        }
    }
}

