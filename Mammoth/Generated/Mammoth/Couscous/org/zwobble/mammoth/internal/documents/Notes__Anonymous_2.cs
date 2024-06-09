namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        public Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notesOfType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, string>(notesOfType, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes__Anonymous_1());
        }
    }
}

