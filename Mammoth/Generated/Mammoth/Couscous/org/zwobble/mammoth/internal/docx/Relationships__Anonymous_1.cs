using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsAnonymous1 : IFunction<Relationship, IMapEntry<string, string>> {
        public IMapEntry<string, string> Apply(Relationship relationship)
        {
            return Maps.Entry(relationship.Type, relationship.Target);
        }
    }
}
