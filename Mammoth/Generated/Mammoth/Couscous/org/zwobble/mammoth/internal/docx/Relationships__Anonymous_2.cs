namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships__Anonymous_2 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _relationshipId;
        internal Relationships__Anonymous_2(string relationshipId) {
            this._relationshipId = relationshipId;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException(("Could not find relationship '" + this._relationshipId) + "'");
        }
    }
}

