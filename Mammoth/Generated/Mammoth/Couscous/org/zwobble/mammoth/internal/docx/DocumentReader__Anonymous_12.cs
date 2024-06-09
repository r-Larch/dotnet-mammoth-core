using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous12 : IFunction<XmlElement, ContentTypes> {
        public ContentTypes Apply(XmlElement arg0)
        {
            return ContentTypesXml.ReadContentTypesXmlElement(arg0);
        }
    }
}
