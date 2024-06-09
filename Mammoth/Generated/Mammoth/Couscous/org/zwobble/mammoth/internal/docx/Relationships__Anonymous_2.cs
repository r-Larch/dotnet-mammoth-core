using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships__Anonymous_2 : Supplier<RuntimeException> {
        private string _relationshipId;

        internal Relationships__Anonymous_2(string relationshipId)
        {
            _relationshipId = relationshipId;
        }

        public RuntimeException get()
        {
            return new RuntimeException(("Could not find relationship '" + _relationshipId) + "'");
        }
    }
}
