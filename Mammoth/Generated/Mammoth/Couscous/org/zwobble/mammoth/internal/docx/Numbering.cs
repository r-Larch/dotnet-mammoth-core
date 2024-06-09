namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _EMPTY;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> _numbering;
        static Numbering() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>());
        }
        internal Numbering(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> numbering) {
            this._numbering = numbering;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> findLevel(string numId, string level) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(this._numbering, numId)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_0(level));
        }
    }
}

