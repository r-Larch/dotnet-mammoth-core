namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _EMPTY;
        internal Mammoth.Couscous.java.util.Map<string, string> _targetsByRelationshipId;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.List<string>> _targetsByType;
        static Relationships() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>());
        }
        internal Relationships(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> relationships) {
            this._targetsByRelationshipId = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship, string, string>(relationships, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships__Anonymous_0());
            this._targetsByType = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMultiMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship, string, string>(relationships, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships__Anonymous_1());
        }
        public string findTargetByRelationshipId(string relationshipId) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._targetsByRelationshipId, relationshipId)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships__Anonymous_2(relationshipId));
        }
        public Mammoth.Couscous.java.util.List<string> findTargetsByType(string type) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.java.util.List<string>>(this._targetsByType, type)).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>());
        }
    }
}

