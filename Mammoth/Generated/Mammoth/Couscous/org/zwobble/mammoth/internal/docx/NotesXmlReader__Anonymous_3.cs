using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReaderAnonymous3 : IFunction<IList<IDocumentElement>, Note> {
        private XmlElement _element;
        private NotesXmlReader _thisOrgZwobbleMammothInternalDocxNotesXmlReader;

        internal NotesXmlReaderAnonymous3(NotesXmlReader thisOrgZwobbleMammothInternalDocxNotesXmlReader, XmlElement element)
        {
            _thisOrgZwobbleMammothInternalDocxNotesXmlReader = thisOrgZwobbleMammothInternalDocxNotesXmlReader;
            _element = element;
        }

        public Note Apply(IList<IDocumentElement> children)
        {
            return new Note((_thisOrgZwobbleMammothInternalDocxNotesXmlReader).NoteType, (_element).GetAttribute("w:id"), children);
        }
    }
}
