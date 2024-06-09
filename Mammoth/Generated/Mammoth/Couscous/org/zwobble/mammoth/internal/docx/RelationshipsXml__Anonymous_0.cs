using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXmlAnonymous0 : IFunction<XmlElement, Relationship> {
        public Relationship Apply(XmlElement arg0)
        {
            return RelationshipsXml.ReadRelationship(arg0);
        }
    }
}
