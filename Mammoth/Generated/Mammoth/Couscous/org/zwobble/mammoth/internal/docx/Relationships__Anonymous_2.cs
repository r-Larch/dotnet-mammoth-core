using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsAnonymous2 : ISupplier<RuntimeException> {
        private string _relationshipId;

        internal RelationshipsAnonymous2(string relationshipId)
        {
            _relationshipId = relationshipId;
        }

        public RuntimeException Get()
        {
            return new RuntimeException(("Could not find relationship '" + _relationshipId) + "'");
        }
    }
}
