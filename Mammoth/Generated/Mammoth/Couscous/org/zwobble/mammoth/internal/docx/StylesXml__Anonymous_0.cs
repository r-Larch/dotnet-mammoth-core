using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml__Anonymous_0 : Predicate<XmlElement> {
        internal string _styleType;

        internal StylesXml__Anonymous_0(string styleType)
        {
            _styleType = styleType;
        }

        public bool test(XmlElement styleElement)
        {
            return (styleElement.getAttribute("w:type")).Equals(_styleType);
        }
    }
}
