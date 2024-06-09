using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml {
        public static Styles ReadStylesXmlElement(XmlElement element)
        {
            var styleElements = element.FindChildren("w:style");
            return new Styles(ReadStyles(styleElements, "paragraph"), ReadStyles(styleElements, "character"), ReadStyles(styleElements, "table"));
        }

        public static IMap<string, Style> ReadStyles(XmlElementList styleElements, string styleType)
        {
            return Maps.ToMap(Iterables.LazyFilter(styleElements, new StylesXmlAnonymous0(styleType)), new StylesXmlAnonymous1());
        }

        public static IMapEntry<string, Style> ReadStyle(XmlElement element)
        {
            var styleId = element.GetAttribute("w:styleId");
            var styleName = (element.FindChildOrEmpty("w:name")).GetAttributeOrNone("w:val");
            return Maps.Entry(styleId, new Style(styleId, styleName));
        }
    }
}
