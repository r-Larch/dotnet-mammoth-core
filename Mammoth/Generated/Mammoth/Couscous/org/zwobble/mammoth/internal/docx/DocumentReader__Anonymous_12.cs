using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_12 : Function<XmlElement, ContentTypes> {
        public ContentTypes apply(XmlElement arg0)
        {
            return ContentTypesXml.readContentTypesXmlElement(arg0);
        }
    }
}
