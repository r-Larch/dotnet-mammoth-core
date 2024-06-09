using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml {
        public static Relationships readRelationshipsXmlElement(XmlElement element)
        {
            return new Relationships(Lists.eagerMap(element.findChildren("relationships:Relationship"), new RelationshipsXml__Anonymous_0()));
        }

        public static Relationship readRelationship(XmlElement element)
        {
            var relationshipId = element.getAttribute("Id");
            var target = element.getAttribute("Target");
            var type = element.getAttribute("Type");
            return new Relationship(relationshipId, target, type);
        }
    }
}
