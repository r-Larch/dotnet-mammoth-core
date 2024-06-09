using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMapAnonymous2 : IPredicate<IXmlNode> {
        private XmlElement _element;
        private string _identifyingAttribute;

        internal EmbeddedStyleMapAnonymous2(XmlElement element, string identifyingAttribute)
        {
            _element = element;
            _identifyingAttribute = identifyingAttribute;
        }

        public bool Test(IXmlNode child)
        {
            return ((Casts.TryCast<XmlElement>(typeof(XmlElement), child)).Map(new EmbeddedStyleMapAnonymous1(_element, _identifyingAttribute))).OrElse(false);
        }
    }
}
