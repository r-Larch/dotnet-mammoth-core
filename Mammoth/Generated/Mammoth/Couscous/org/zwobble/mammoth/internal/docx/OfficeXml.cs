using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml {
        internal static NamespacePrefixes _XML_NAMESPACES;

        static OfficeXml()
        {
            _XML_NAMESPACES = (((((((((((NamespacePrefixes.builder()).put("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main")).put("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")).put("a", "http://schemas.openxmlformats.org/drawingml/2006/main")).put("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture")).put("content-types", "http://schemas.openxmlformats.org/package/2006/content-types")).put("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships")).put("relationships", "http://schemas.openxmlformats.org/package/2006/relationships")).put("v", "urn:schemas-microsoft-com:vml")).put("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006")).put("office-word", "urn:schemas-microsoft-com:office:word")).build();
        }

        public static XmlElement parseXml(InputStream inputStream)
        {
            var parser = new XmlParser(_XML_NAMESPACES);
            return (XmlElement) (collapseAlternateContent(parser.parseStream(inputStream))).get(0);
        }

        public static List<XmlNode> collapseAlternateContent(XmlNode node)
        {
            return node.accept(new OfficeXml__Anonymous_1());
        }
    }
}
