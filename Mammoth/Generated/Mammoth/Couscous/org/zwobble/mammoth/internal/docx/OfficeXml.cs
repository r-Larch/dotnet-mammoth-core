using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml {
        private static readonly NamespacePrefixes XmlNamespaces = NamespacePrefixes.Builder()
            .Put("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main")
            .Put("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")
            .Put("a", "http://schemas.openxmlformats.org/drawingml/2006/main")
            .Put("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture")
            .Put("content-types", "http://schemas.openxmlformats.org/package/2006/content-types")
            .Put("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships")
            .Put("relationships", "http://schemas.openxmlformats.org/package/2006/relationships")
            .Put("v", "urn:schemas-microsoft-com:vml")
            .Put("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006")
            .Put("office-word", "urn:schemas-microsoft-com:office:word")
            .Build();

        public static XmlElement ParseXml(INputStream inputStream)
        {
            var parser = new XmlParser(XmlNamespaces);
            return (XmlElement) CollapseAlternateContent(parser.ParseStream(inputStream)).Get(0);
        }

        public static IList<IXmlNode> CollapseAlternateContent(IXmlNode node)
        {
            return node.Accept(new OfficeXmlAnonymous1());
        }
    }

    internal class OfficeXmlAnonymous0 : IFunction<IXmlNode, ITerable<IXmlNode>> {
        public ITerable<IXmlNode> Apply(IXmlNode arg0)
        {
            return OfficeXml.CollapseAlternateContent(arg0);
        }
    }

    internal class OfficeXmlAnonymous1 : IXmlNodeVisitor<IList<IXmlNode>> {
        public IList<IXmlNode> Visit(XmlElement element)
        {
            if (element.GetName().Equals("mc:AlternateContent")) {
                return element.FindChildOrEmpty("mc:Fallback").GetChildren();
            }

            var collapsedElement = new XmlElement(element.GetName(), element.GetAttributes(), Lists.EagerFlatMap(element.GetChildren(), new OfficeXmlAnonymous0()));
            return Lists.List<IXmlNode>(collapsedElement);
        }

        public IList<IXmlNode> Visit(XmlTextNode textNode)
        {
            return Lists.List<IXmlNode>(textNode);
        }
    }
}
