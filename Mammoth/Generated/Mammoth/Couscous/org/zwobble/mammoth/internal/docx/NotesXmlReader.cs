namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal string _tagName;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType _noteType;
        internal NotesXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader, string tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType) {
            this._bodyReader = bodyReader;
            this._tagName = tagName;
            this._noteType = noteType;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader footnote(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader(bodyReader, "footnote", Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader endnote(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader(bodyReader, "endnote", Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> elements = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(element.findChildren("w:" + this._tagName), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader__Anonymous_0(this));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader__Anonymous_1(this));
        }
        public bool isNoteElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return ((element.getAttributeOrNone("w:type")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader__Anonymous_2(this))).orElse(true);
        }
        public bool isSeparatorType(string type) {
            return (type.Equals("continuationSeparator")) || (type.Equals("separator"));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> readNoteElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return (((this._bodyReader).readElements(element.getChildren())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader__Anonymous_3(this, element));
        }
    }
}

