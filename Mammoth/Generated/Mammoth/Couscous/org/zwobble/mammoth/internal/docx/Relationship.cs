namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationship {
        internal string _relationshipId;
        internal string _target;
        internal string _type;
        internal Relationship(string relationshipId, string target, string type) {
            this._relationshipId = relationshipId;
            this._target = target;
            this._type = type;
        }
        public string getRelationshipId() {
            return this._relationshipId;
        }
        public string getTarget() {
            return this._target;
        }
        public string getType() {
            return this._type;
        }
    }
}

