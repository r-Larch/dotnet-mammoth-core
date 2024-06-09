namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles readStylesXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList styleElements = element.findChildren("w:style");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyles(styleElements, "paragraph"), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyles(styleElements, "character"), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyles(styleElements, "table"));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> readStyles(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList styleElements, string styleType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(styleElements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml__Anonymous_0(styleType)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> readStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string styleId = element.getAttribute("w:styleId");
            Mammoth.Couscous.java.util.Optional<string> styleName = (element.findChildOrEmpty("w:name")).getAttributeOrNone("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(styleId, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style(styleId, styleName));
        }
    }
}

