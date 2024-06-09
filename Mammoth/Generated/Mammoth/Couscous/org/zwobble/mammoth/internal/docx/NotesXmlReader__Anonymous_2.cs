using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReaderAnonymous2 : IFunction<string, bool> {
        private NotesXmlReader _thisOrgZwobbleMammothInternalDocxNotesXmlReader;

        internal NotesXmlReaderAnonymous2(NotesXmlReader thisOrgZwobbleMammothInternalDocxNotesXmlReader)
        {
            _thisOrgZwobbleMammothInternalDocxNotesXmlReader = thisOrgZwobbleMammothInternalDocxNotesXmlReader;
        }

        public bool Apply(string type)
        {
            return !(_thisOrgZwobbleMammothInternalDocxNotesXmlReader).IsSeparatorType(type);
        }
    }
}
