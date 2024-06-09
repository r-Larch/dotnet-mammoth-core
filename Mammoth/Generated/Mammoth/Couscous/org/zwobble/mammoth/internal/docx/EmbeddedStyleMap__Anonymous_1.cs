using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap__Anonymous_1 : Function<XmlElement, bool> {
        internal XmlElement _element;
        internal string _identifyingAttribute;

        internal EmbeddedStyleMap__Anonymous_1(XmlElement element, string identifyingAttribute)
        {
            _element = element;
            _identifyingAttribute = identifyingAttribute;
        }

        public bool apply(XmlElement childElement)
        {
            return ((childElement.getName()).Equals((_element).getName())) && (childElement.getAttributeOrNone(_identifyingAttribute)).equals((_element).getAttributeOrNone(_identifyingAttribute));
        }
    }
}
