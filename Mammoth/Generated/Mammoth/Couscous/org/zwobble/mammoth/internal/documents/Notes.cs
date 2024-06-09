namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _EMPTY;
        internal Mammoth.Couscous.java.util.Map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> _notes;
        static Notes() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>());
        }
        internal Notes(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notes) {
            this._notes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.eagerMapValues<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMultiMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType>(notes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes__Anonymous_0()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes__Anonymous_2());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> findNote(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(this._notes, noteType)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes__Anonymous_3(noteId));
        }
    }
}

