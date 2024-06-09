using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml {
        public static ContentTypes ReadContentTypesXmlElement(XmlElement element)
        {
            return new ContentTypes(ReadDefaults(element.FindChildren("content-types:Default")), ReadOverrides(element.FindChildren("content-types:Override")));
        }

        public static IMap<string, string> ReadDefaults(XmlElementList children)
        {
            return Maps.ToMap(children, new ContentTypesXmlAnonymous0());
        }

        public static IMapEntry<string, string> ReadDefault(XmlElement element)
        {
            return Maps.Entry(element.GetAttribute("Extension"), element.GetAttribute("ContentType"));
        }

        public static IMap<string, string> ReadOverrides(XmlElementList children)
        {
            return Maps.ToMap(children, new ContentTypesXmlAnonymous1());
        }

        public static IMapEntry<string, string> ReadOverride(XmlElement element)
        {
            return Maps.Entry(Strings.TrimLeft(element.GetAttribute("PartName"), '/'), element.GetAttribute("ContentType"));
        }
    }
}
