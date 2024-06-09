namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            if ((element.getName()).Equals("mc:AlternateContent")) {
                return (element.findChildOrEmpty("mc:Fallback")).getChildren();
            } else {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement collapsedElement = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(element.getName(), element.getAttributes(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(element.getChildren(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml__Anonymous_0()));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(collapsedElement);
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode textNode) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(textNode);
        }
    }
}

