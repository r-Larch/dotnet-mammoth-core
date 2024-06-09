using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader {
        private BodyXmlReader _bodyReader;
        public NoteType NoteType;
        private string _tagName;

        internal NotesXmlReader(BodyXmlReader bodyReader, string tagName, NoteType noteType)
        {
            _bodyReader = bodyReader;
            _tagName = tagName;
            NoteType = noteType;
        }

        public static NotesXmlReader Footnote(BodyXmlReader bodyReader)
        {
            return new NotesXmlReader(bodyReader, "footnote", NoteType.Footnote);
        }

        public static NotesXmlReader Endnote(BodyXmlReader bodyReader)
        {
            return new NotesXmlReader(bodyReader, "endnote", NoteType.Endnote);
        }

        public InternalResult<IList<Note>> ReadElement(XmlElement element)
        {
            var elements = Iterables.LazyFilter(element.FindChildren("w:" + _tagName), new NotesXmlReaderAnonymous0(this));
            return InternalResult.FlatMap(elements, new NotesXmlReaderAnonymous1(this));
        }

        public bool IsNoteElement(XmlElement element)
        {
            return ((element.GetAttributeOrNone("w:type")).Map(new NotesXmlReaderAnonymous2(this))).OrElse(true);
        }

        public bool IsSeparatorType(string type)
        {
            return (type.Equals("continuationSeparator")) || (type.Equals("separator"));
        }

        public InternalResult<Note> ReadNoteElement(XmlElement element)
        {
            return (((_bodyReader).ReadElements(element.GetChildren())).ToResult()).Map(new NotesXmlReaderAnonymous3(this, element));
        }
    }
}
