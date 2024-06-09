namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes readContentTypesXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readDefaults(element.findChildren("content-types:Default")), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readOverrides(element.findChildren("content-types:Override")));
        }
        public static Mammoth.Couscous.java.util.Map<string, string> readDefaults(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, string>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml__Anonymous_0());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, string> readDefault(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(element.getAttribute("Extension"), element.getAttribute("ContentType"));
        }
        public static Mammoth.Couscous.java.util.Map<string, string> readOverrides(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, string>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, string> readOverride(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.trimLeft(element.getAttribute("PartName"), '/'), element.getAttribute("ContentType"));
        }
    }
}

