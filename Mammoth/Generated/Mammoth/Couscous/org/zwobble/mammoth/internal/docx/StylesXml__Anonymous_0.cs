using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXmlAnonymous0 : IPredicate<XmlElement> {
        private string _styleType;

        internal StylesXmlAnonymous0(string styleType)
        {
            _styleType = styleType;
        }

        public bool Test(XmlElement styleElement)
        {
            return (styleElement.GetAttribute("w:type")).Equals(_styleType);
        }
    }
}
