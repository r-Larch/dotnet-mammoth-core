using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous2 : IFunction<string, string> {
        private IArchive _archive;
        private string _documentFilename;
        private Relationships _documentRelationships;

        internal DocumentReaderAnonymous2(IArchive archive, Relationships documentRelationships, string documentFilename)
        {
            _archive = archive;
            _documentRelationships = documentRelationships;
            _documentFilename = documentFilename;
        }

        public string Apply(string name)
        {
            return DocumentReader.FindPartPath(_archive, _documentRelationships, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/" + name, (ZipPaths.SplitPath(_documentFilename)).GetDirname(), ("word/" + name) + ".xml");
        }
    }
}
