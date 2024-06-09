using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml {
        public static ContentTypes readContentTypesXmlElement(XmlElement element)
        {
            return new ContentTypes(readDefaults(element.findChildren("content-types:Default")), readOverrides(element.findChildren("content-types:Override")));
        }

        public static Map<string, string> readDefaults(XmlElementList children)
        {
            return Maps.toMap(children, new ContentTypesXml__Anonymous_0());
        }

        public static Map__Entry<string, string> readDefault(XmlElement element)
        {
            return Maps.entry(element.getAttribute("Extension"), element.getAttribute("ContentType"));
        }

        public static Map<string, string> readOverrides(XmlElementList children)
        {
            return Maps.toMap(children, new ContentTypesXml__Anonymous_1());
        }

        public static Map__Entry<string, string> readOverride(XmlElement element)
        {
            return Maps.entry(Strings.trimLeft(element.getAttribute("PartName"), '/'), element.getAttribute("ContentType"));
        }
    }
}
