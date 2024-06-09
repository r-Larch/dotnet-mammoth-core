using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap__Anonymous_2 : Predicate<XmlNode> {
        private XmlElement _element;
        private string _identifyingAttribute;

        internal EmbeddedStyleMap__Anonymous_2(XmlElement element, string identifyingAttribute)
        {
            _element = element;
            _identifyingAttribute = identifyingAttribute;
        }

        public bool test(XmlNode child)
        {
            return ((Casts.tryCast<XmlElement>(typeof(XmlElement), child)).map(new EmbeddedStyleMap__Anonymous_1(_element, _identifyingAttribute))).orElse(false);
        }
    }
}
