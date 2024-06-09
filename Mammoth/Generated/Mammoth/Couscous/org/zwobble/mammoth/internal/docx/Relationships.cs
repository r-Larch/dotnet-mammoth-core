using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships {
        public static Relationships _EMPTY;
        private Map<string, string> _targetsByRelationshipId;
        private Map<string, List<string>> _targetsByType;

        static Relationships()
        {
            _EMPTY = new Relationships(Lists.list<Relationship>());
        }

        internal Relationships(List<Relationship> relationships)
        {
            _targetsByRelationshipId = Maps.toMap(relationships, new Relationships__Anonymous_0());
            _targetsByType = Maps.toMultiMap(relationships, new Relationships__Anonymous_1());
        }

        public string findTargetByRelationshipId(string relationshipId)
        {
            return (Maps.lookup(_targetsByRelationshipId, relationshipId)).orElseThrow(new Relationships__Anonymous_2(relationshipId));
        }

        public List<string> findTargetsByType(string type)
        {
            return (Maps.lookup(_targetsByType, type)).orElse(Lists.list<string>());
        }
    }
}
