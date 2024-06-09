using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous13 : IFunction<XmlElement, Relationships> {
        public Relationships Apply(XmlElement arg0)
        {
            return RelationshipsXml.ReadRelationshipsXmlElement(arg0);
        }
    }
}
