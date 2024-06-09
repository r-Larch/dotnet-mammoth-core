namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<string, bool> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal NotesXmlReader__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }
        public bool apply(string type) {
            return !(this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader).isSeparatorType(type);
        }
    }
}

