using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXmlAnonymous0(string styleType) : IPredicate<XmlElement> {
        public bool Test(XmlElement styleElement)
        {
            return styleElement.GetAttribute("w:type").Equals(styleType);
        }
    }

    internal class StylesXmlAnonymous1 : IFunction<XmlElement, IMapEntry<string, Style>> {
        public IMapEntry<string, Style> Apply(XmlElement arg0)
        {
            return StylesXml.ReadStyle(arg0);
        }
    }
}
