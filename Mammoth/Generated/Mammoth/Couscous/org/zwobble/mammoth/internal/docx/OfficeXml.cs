namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _XML_NAMESPACES;
        static OfficeXml() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml._XML_NAMESPACES = (((((((((((Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes.builder()).put("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main")).put("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")).put("a", "http://schemas.openxmlformats.org/drawingml/2006/main")).put("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture")).put("content-types", "http://schemas.openxmlformats.org/package/2006/content-types")).put("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships")).put("relationships", "http://schemas.openxmlformats.org/package/2006/relationships")).put("v", "urn:schemas-microsoft-com:vml")).put("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006")).put("office-word", "urn:schemas-microsoft-com:office:word")).build();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseXml(Mammoth.Couscous.java.io.InputStream inputStream) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser parser = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml._XML_NAMESPACES);
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement) (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml.collapseAlternateContent(parser.parseStream(inputStream))).get(0);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> collapseAlternateContent(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode node) {
            return node.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml__Anonymous_1());
        }
    }
}

