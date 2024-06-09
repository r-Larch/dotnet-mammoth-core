using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml {
        public static Styles readStylesXmlElement(XmlElement element)
        {
            var styleElements = element.findChildren("w:style");
            return new Styles(readStyles(styleElements, "paragraph"), readStyles(styleElements, "character"), readStyles(styleElements, "table"));
        }

        public static Map<string, Style> readStyles(XmlElementList styleElements, string styleType)
        {
            return Maps.toMap(Iterables.lazyFilter(styleElements, new StylesXml__Anonymous_0(styleType)), new StylesXml__Anonymous_1());
        }

        public static Map__Entry<string, Style> readStyle(XmlElement element)
        {
            var styleId = element.getAttribute("w:styleId");
            var styleName = (element.findChildOrEmpty("w:name")).getAttributeOrNone("w:val");
            return Maps.entry(styleId, new Style(styleId, styleName));
        }
    }
}
