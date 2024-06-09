namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        internal string _noteId;
        internal Notes__Anonymous_3(string noteId) {
            this._noteId = noteId;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notesOfType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(notesOfType, this._noteId);
        }
    }
}

