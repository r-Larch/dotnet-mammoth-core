namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationship {
        private string _relationshipId;
        private string _target;
        private string _type;

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
