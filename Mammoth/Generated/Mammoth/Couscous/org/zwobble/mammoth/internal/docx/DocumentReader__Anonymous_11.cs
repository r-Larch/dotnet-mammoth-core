using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_11 : Function<XmlElement, Numbering> {
        public Numbering apply(XmlElement arg0)
        {
            return NumberingXml.readNumberingXmlElement(arg0);
        }
    }
}
