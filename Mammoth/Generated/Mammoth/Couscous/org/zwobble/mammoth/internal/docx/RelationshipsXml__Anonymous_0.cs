using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml__Anonymous_0 : Function<XmlElement, Relationship> {
        public Relationship apply(XmlElement arg0)
        {
            return RelationshipsXml.readRelationship(arg0);
        }
    }
}
