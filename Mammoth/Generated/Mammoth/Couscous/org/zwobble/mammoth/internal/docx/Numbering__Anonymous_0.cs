namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        internal string _level;
        internal Numbering__Anonymous_0(string level) {
            this._level = level;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> levels) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(levels, this._level);
        }
    }
}

