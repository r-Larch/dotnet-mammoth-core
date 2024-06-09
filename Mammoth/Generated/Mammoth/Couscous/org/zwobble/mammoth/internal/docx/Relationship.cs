namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationship {
        public string RelationshipId { get; }
        public string Target { get; }
        public string Type { get; }

        internal Relationship(string relationshipId, string target, string type)
        {
            RelationshipId = relationshipId;
            Target = target;
            Type = type;
        }
    }
}
