namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal NotesXmlReader__Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
            this._element = element;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note((this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader)._noteType, (this._element).getAttribute("w:id"), children);
        }
    }
}

