namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship, Mammoth.Couscous.java.util.Map__Entry<string, string>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship relationship) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(relationship.getType(), relationship.getTarget());
        }
    }
}

