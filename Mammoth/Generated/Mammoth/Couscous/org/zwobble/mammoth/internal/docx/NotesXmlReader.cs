using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader {
        private BodyXmlReader _bodyReader;
        public NoteType _noteType;
        private string _tagName;

        internal NotesXmlReader(BodyXmlReader bodyReader, string tagName, NoteType noteType)
        {
            _bodyReader = bodyReader;
            _tagName = tagName;
            _noteType = noteType;
        }

        public static NotesXmlReader footnote(BodyXmlReader bodyReader)
        {
            return new NotesXmlReader(bodyReader, "footnote", NoteType._FOOTNOTE);
        }

        public static NotesXmlReader endnote(BodyXmlReader bodyReader)
        {
            return new NotesXmlReader(bodyReader, "endnote", NoteType._ENDNOTE);
        }

        public InternalResult<List<Note>> readElement(XmlElement element)
        {
            var elements = Iterables.lazyFilter(element.findChildren("w:" + _tagName), new NotesXmlReader__Anonymous_0(this));
            return InternalResult.flatMap(elements, new NotesXmlReader__Anonymous_1(this));
        }

        public bool isNoteElement(XmlElement element)
        {
            return ((element.getAttributeOrNone("w:type")).map(new NotesXmlReader__Anonymous_2(this))).orElse(true);
        }

        public bool isSeparatorType(string type)
        {
            return (type.Equals("continuationSeparator")) || (type.Equals("separator"));
        }

        public InternalResult<Note> readNoteElement(XmlElement element)
        {
            return (((_bodyReader).readElements(element.getChildren())).toResult()).map(new NotesXmlReader__Anonymous_3(this, element));
        }
    }
}
