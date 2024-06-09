using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml {
        private static NamespacePrefixes _xmlNamespaces;

        static OfficeXml()
        {
            _xmlNamespaces = (((((((((((NamespacePrefixes.Builder()).Put("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main")).Put("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")).Put("a", "http://schemas.openxmlformats.org/drawingml/2006/main")).Put("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture")).Put("content-types", "http://schemas.openxmlformats.org/package/2006/content-types")).Put("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships")).Put("relationships", "http://schemas.openxmlformats.org/package/2006/relationships")).Put("v", "urn:schemas-microsoft-com:vml")).Put("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006")).Put("office-word", "urn:schemas-microsoft-com:office:word")).Build();
        }

        public static XmlElement ParseXml(INputStream inputStream)
        {
            var parser = new XmlParser(_xmlNamespaces);
            return (XmlElement) (CollapseAlternateContent(parser.ParseStream(inputStream))).Get(0);
        }

        public static IList<IXmlNode> CollapseAlternateContent(IXmlNode node)
        {
            return node.Accept(new OfficeXmlAnonymous1());
        }
    }
}
