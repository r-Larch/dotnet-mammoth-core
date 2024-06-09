using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships {
        public static Relationships Empty;
        private IMap<string, string> _targetsByRelationshipId;
        private IMap<string, IList<string>> _targetsByType;

        static Relationships()
        {
            Empty = new Relationships(Lists.List<Relationship>());
        }

        internal Relationships(IList<Relationship> relationships)
        {
            _targetsByRelationshipId = Maps.ToMap(relationships, new RelationshipsAnonymous0());
            _targetsByType = Maps.ToMultiMap(relationships, new RelationshipsAnonymous1());
        }

        public string FindTargetByRelationshipId(string relationshipId)
        {
            return (Maps.Lookup(_targetsByRelationshipId, relationshipId)).OrElseThrow(new RelationshipsAnonymous2(relationshipId));
        }

        public IList<string> FindTargetsByType(string type)
        {
            return (Maps.Lookup(_targetsByType, type)).OrElse(Lists.List<string>());
        }
    }
}
