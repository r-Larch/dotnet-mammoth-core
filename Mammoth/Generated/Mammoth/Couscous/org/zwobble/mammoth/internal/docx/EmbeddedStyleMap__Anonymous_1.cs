using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMapAnonymous1 : IFunction<XmlElement, bool> {
        private XmlElement _element;
        private string _identifyingAttribute;

        internal EmbeddedStyleMapAnonymous1(XmlElement element, string identifyingAttribute)
        {
            _element = element;
            _identifyingAttribute = identifyingAttribute;
        }

        public bool Apply(XmlElement childElement)
        {
            return ((childElement.GetName()).Equals((_element).GetName())) && (childElement.GetAttributeOrNone(_identifyingAttribute)).Equals((_element).GetAttributeOrNone(_identifyingAttribute));
        }
    }
}
