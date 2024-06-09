namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Styles {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _EMPTY;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _paragraphStyles;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _characterStyles;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _tableStyles;
        static Styles() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>());
        }
        internal Styles(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> paragraphStyles, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> characterStyles, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> tableStyles) {
            this._paragraphStyles = paragraphStyles;
            this._characterStyles = characterStyles;
            this._tableStyles = tableStyles;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> findParagraphStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(this._paragraphStyles, id);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> findCharacterStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(this._characterStyles, id);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> findTableStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(this._tableStyles, id);
        }
    }
}

