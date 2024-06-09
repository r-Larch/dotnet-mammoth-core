using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml__Anonymous_0 : Function<XmlNode, Iterable<XmlNode>> {
        public Iterable<XmlNode> apply(XmlNode arg0)
        {
            return OfficeXml.collapseAlternateContent(arg0);
        }
    }
}
