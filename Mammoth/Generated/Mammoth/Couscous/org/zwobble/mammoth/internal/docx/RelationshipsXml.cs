namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships readRelationshipsXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>(element.findChildren("relationships:Relationship"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml__Anonymous_0()));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship readRelationship(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string relationshipId = element.getAttribute("Id");
            string target = element.getAttribute("Target");
            string type = element.getAttribute("Type");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship(relationshipId, target, type);
        }
    }
}

