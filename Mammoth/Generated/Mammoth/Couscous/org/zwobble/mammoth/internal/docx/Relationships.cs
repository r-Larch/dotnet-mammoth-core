using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships(IList<Relationship> relationships) {
        public static Relationships Empty = new(Lists.List<Relationship>());
        private readonly IMap<string, string> _targetsByRelationshipId = Maps.ToMap(relationships, new RelationshipsAnonymous0());
        private readonly IMap<string, IList<string>> _targetsByType = Maps.ToMultiMap(relationships, new RelationshipsAnonymous1());

        public string FindTargetByRelationshipId(string relationshipId)
        {
            return Maps.Lookup(_targetsByRelationshipId, relationshipId).OrElseThrow(new RelationshipsAnonymous2(relationshipId));
        }

        public IList<string> FindTargetsByType(string type)
        {
            return Maps.Lookup(_targetsByType, type).OrElse(Lists.List<string>());
        }
    }

    internal class RelationshipsAnonymous0 : IFunction<Relationship, IMapEntry<string, string>> {
        public IMapEntry<string, string> Apply(Relationship relationship)
        {
            return Maps.Entry(relationship.RelationshipId, relationship.Target);
        }
    }

    internal class RelationshipsAnonymous1 : IFunction<Relationship, IMapEntry<string, string>> {
        public IMapEntry<string, string> Apply(Relationship relationship)
        {
            return Maps.Entry(relationship.Type, relationship.Target);
        }
    }

    internal class RelationshipsAnonymous2 : ISupplier<RuntimeException> {
        private readonly string _relationshipId;

        internal RelationshipsAnonymous2(string relationshipId)
        {
            _relationshipId = relationshipId;
        }

        public RuntimeException Get()
        {
            return new RuntimeException($"Could not find relationship '{_relationshipId}'");
        }
    }
}
