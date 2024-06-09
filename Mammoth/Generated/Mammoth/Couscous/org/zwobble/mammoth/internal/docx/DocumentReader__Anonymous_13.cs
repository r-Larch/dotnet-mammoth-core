using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_13 : Function<XmlElement, Relationships> {
        public Relationships apply(XmlElement arg0)
        {
            return RelationshipsXml.readRelationshipsXmlElement(arg0);
        }
    }
}
