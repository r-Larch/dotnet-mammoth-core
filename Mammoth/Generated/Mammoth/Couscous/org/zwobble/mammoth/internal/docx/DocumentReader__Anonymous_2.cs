namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _archive;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _documentRelationships;
        internal string _documentFilename;
        internal DocumentReader__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships documentRelationships, string documentFilename) {
            this._archive = archive;
            this._documentRelationships = documentRelationships;
            this._documentFilename = documentFilename;
        }
        public string apply(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.findPartPath(this._archive, this._documentRelationships, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/" + name, (Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths.splitPath(this._documentFilename)).getDirname(), ("word/" + name) + ".xml");
        }
    }
}

