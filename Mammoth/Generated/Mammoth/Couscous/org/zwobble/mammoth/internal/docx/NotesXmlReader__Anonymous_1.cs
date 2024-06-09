namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal NotesXmlReader__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader).readNoteElement(arg0);
        }
    }
}

