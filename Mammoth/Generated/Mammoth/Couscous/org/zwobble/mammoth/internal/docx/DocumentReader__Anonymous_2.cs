using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_2 : Function<string, string> {
        private Archive _archive;
        private string _documentFilename;
        private Relationships _documentRelationships;

        internal DocumentReader__Anonymous_2(Archive archive, Relationships documentRelationships, string documentFilename)
        {
            _archive = archive;
            _documentRelationships = documentRelationships;
            _documentFilename = documentFilename;
        }

        public string apply(string name)
        {
            return DocumentReader.findPartPath(_archive, _documentRelationships, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/" + name, (ZipPaths.splitPath(_documentFilename)).getDirname(), ("word/" + name) + ".xml");
        }
    }
}
