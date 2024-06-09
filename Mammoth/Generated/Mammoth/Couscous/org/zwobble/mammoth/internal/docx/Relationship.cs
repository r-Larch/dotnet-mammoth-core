namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationship {
        internal string _relationshipId;
        internal string _target;
        internal string _type;

        internal Relationship(string relationshipId, string target, string type)
        {
            _relationshipId = relationshipId;
            _target = target;
            _type = type;
        }

        public string getRelationshipId()
        {
            return _relationshipId;
        }

        public string getTarget()
        {
            return _target;
        }

        public string getType()
        {
            return _type;
        }
    }
}
