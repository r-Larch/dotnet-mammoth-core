using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReaderAnonymous0(NotesXmlReader reader) : IPredicate<XmlElement> {
        public bool Test(XmlElement arg0)
        {
            return reader.IsNoteElement(arg0);
        }
    }

    internal class NotesXmlReaderAnonymous1(NotesXmlReader reader) : IFunction<XmlElement, InternalResult<Note>> {
        public InternalResult<Note> Apply(XmlElement arg0)
        {
            return reader.ReadNoteElement(arg0);
        }
    }

    internal class NotesXmlReaderAnonymous2(NotesXmlReader reader) : IFunction<string, bool> {
        public bool Apply(string type)
        {
            return !reader.IsSeparatorType(type);
        }
    }

    internal class NotesXmlReaderAnonymous3(NotesXmlReader reader, XmlElement element) : IFunction<IList<IDocumentElement>, Note> {
        public Note Apply(IList<IDocumentElement> children)
        {
            return new Note(reader.NoteType, element.GetAttribute("w:id"), children);
        }
    }
}
