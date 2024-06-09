using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReaderAnonymous0 : IPredicate<XmlElement> {
        private NotesXmlReader _thisOrgZwobbleMammothInternalDocxNotesXmlReader;

        internal NotesXmlReaderAnonymous0(NotesXmlReader thisOrgZwobbleMammothInternalDocxNotesXmlReader)
        {
            _thisOrgZwobbleMammothInternalDocxNotesXmlReader = thisOrgZwobbleMammothInternalDocxNotesXmlReader;
        }

        public bool Test(XmlElement arg0)
        {
            return (_thisOrgZwobbleMammothInternalDocxNotesXmlReader).IsNoteElement(arg0);
        }
    }
}
