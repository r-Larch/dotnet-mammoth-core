using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships__Anonymous_0 : Function<Relationship, Map__Entry<string, string>> {
        public Map__Entry<string, string> apply(Relationship relationship)
        {
            return Maps.entry(relationship.getRelationshipId(), relationship.getTarget());
        }
    }
}
