using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXmlAnonymous1 : IXmlNodeVisitor<IList<IXmlNode>> {
        public IList<IXmlNode> Visit(XmlElement element)
        {
            if ((element.GetName()).Equals("mc:AlternateContent")) {
                return (element.FindChildOrEmpty("mc:Fallback")).GetChildren();
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
