using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml {
        public static Relationships ReadRelationshipsXmlElement(XmlElement element)
        {
            return new Relationships(Lists.EagerMap(element.FindChildren("relationships:Relationship"), new RelationshipsXmlAnonymous0()));
        }

        public static Relationship ReadRelationship(XmlElement element)
        {
            var relationshipId = element.GetAttribute("Id");
            var target = element.GetAttribute("Target");
            var type = element.GetAttribute("Type");
            return new Relationship(relationshipId, target, type);
        }
    }

    internal class RelationshipsXmlAnonymous0 : IFunction<XmlElement, Relationship> {
        public Relationship Apply(XmlElement arg0)
        {
            return RelationshipsXml.ReadRelationship(arg0);
        }
    }
}
