using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReaderAnonymous1 : IFunction<XmlElement, InternalResult<Note>> {
        private NotesXmlReader _thisOrgZwobbleMammothInternalDocxNotesXmlReader;

        internal NotesXmlReaderAnonymous1(NotesXmlReader thisOrgZwobbleMammothInternalDocxNotesXmlReader)
        {
            _thisOrgZwobbleMammothInternalDocxNotesXmlReader = thisOrgZwobbleMammothInternalDocxNotesXmlReader;
        }

        public InternalResult<Note> Apply(XmlElement arg0)
        {
            return (_thisOrgZwobbleMammothInternalDocxNotesXmlReader).ReadNoteElement(arg0);
        }
    }
}
