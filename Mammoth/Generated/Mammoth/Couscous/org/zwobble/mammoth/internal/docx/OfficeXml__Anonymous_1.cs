using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml__Anonymous_1 : XmlNodeVisitor<List<XmlNode>> {
        public List<XmlNode> visit(XmlElement element)
        {
            if ((element.getName()).Equals("mc:AlternateContent")) {
                return (element.findChildOrEmpty("mc:Fallback")).getChildren();
            }

            var collapsedElement = new XmlElement(element.getName(), element.getAttributes(), Lists.eagerFlatMap(element.getChildren(), new OfficeXml__Anonymous_0()));
            return Lists.list<XmlNode>(collapsedElement);
        }

        public List<XmlNode> visit(XmlTextNode textNode)
        {
            return Lists.list<XmlNode>(textNode);
        }
    }
}
