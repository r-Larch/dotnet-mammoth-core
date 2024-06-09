using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous10 : IFunction<XmlElement, Styles> {
        public Styles Apply(XmlElement arg0)
        {
            return StylesXml.ReadStylesXmlElement(arg0);
        }
    }
}
