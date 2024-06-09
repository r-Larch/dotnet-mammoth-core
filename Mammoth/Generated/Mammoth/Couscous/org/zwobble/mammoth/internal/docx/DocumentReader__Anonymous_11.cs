using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous11 : IFunction<XmlElement, Numbering> {
        public Numbering Apply(XmlElement arg0)
        {
            return NumberingXml.ReadNumberingXmlElement(arg0);
        }
    }
}
