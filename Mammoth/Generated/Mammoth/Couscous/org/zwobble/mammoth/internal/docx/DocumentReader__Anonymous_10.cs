using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_10 : Function<XmlElement, Styles> {
        public Styles apply(XmlElement arg0)
        {
            return StylesXml.readStylesXmlElement(arg0);
        }
    }
}
