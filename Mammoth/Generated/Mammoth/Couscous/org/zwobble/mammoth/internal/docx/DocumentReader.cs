using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.nio.file;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader {
        public static InternalResult<Document> readDocument(Optional<Path> path, Archive zipFile)
        {
            var partPaths = findPartPaths(zipFile);
            var styles = readStyles(zipFile, partPaths);
            var numbering = readNumbering(zipFile, partPaths);
            var contentTypes = readContentTypes(zipFile);
            FileReader fileReader = new PathRelativeFileReader(path);
            var partReader = new DocumentReader__PartWithBodyReader(zipFile, contentTypes, fileReader, numbering, styles);
            return InternalResult.flatMap(readNotes(partReader, partPaths), readComments(partReader, partPaths), new DocumentReader__Anonymous_1(partReader, partPaths));
        }

        public static DocumentReader__PartPaths findPartPaths(Archive archive)
        {
            var packageRelationships = readPackageRelationships(archive);
            var documentFilename = findDocumentFilename(archive, packageRelationships);
            var documentRelationships = readRelationships(archive, findRelationshipsPathFor(documentFilename));
            Function<string, string> find = new DocumentReader__Anonymous_2(archive, documentRelationships, documentFilename);
            return new DocumentReader__PartPaths(documentFilename, find.apply("comments"), find.apply("endnotes"), find.apply("footnotes"), find.apply("numbering"), find.apply("styles"));
        }

        public static Relationships readPackageRelationships(Archive archive)
        {
            return readRelationships(archive, "_rels/.rels");
        }

        public static string findDocumentFilename(Archive archive, Relationships packageRelationships)
        {
            var officeDocumentType = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
            var mainDocumentPath = findPartPath(archive, packageRelationships, officeDocumentType, "", "word/document.xml");
            if (archive.exists(mainDocumentPath)) {
                return mainDocumentPath;
            }

            throw new PassThroughException(new IOException("Could not find main document part. Are you sure this is a valid .docx file?"));
        }

        public static string findPartPath(Archive archive, Relationships relationships, string relationshipType, string basePath, string fallbackPath)
        {
            var targets = Lists.eagerMap(relationships.findTargetsByType(relationshipType), new DocumentReader__Anonymous_3(basePath));
            var validTargets = Lists.eagerFilter(targets, new DocumentReader__Anonymous_4(archive));
            return (Lists.tryGetFirst(validTargets)).orElse(fallbackPath);
        }

        public static InternalResult<List<Comment>> readComments(DocumentReader__PartWithBodyReader partReader, DocumentReader__PartPaths partPaths)
        {
            return partReader.readPart(partPaths.getComments(), new DocumentReader__Anonymous_5(), Optional.of(InternalResult.success(Lists.list<Comment>())));
        }

        public static InternalResult<Notes> readNotes(DocumentReader__PartWithBodyReader partReader, DocumentReader__PartPaths partPaths)
        {
            return (InternalResult.map(partReader.readPart(partPaths.getFootnotes(), new DocumentReader__Anonymous_6(), Optional.of(InternalResult.success(Lists.list<Note>()))), partReader.readPart(partPaths.getEndnotes(), new DocumentReader__Anonymous_7(), Optional.of(InternalResult.success(Lists.list<Note>()))), new DocumentReader__Anonymous_8())).map(new DocumentReader__Anonymous_9());
        }

        public static Styles readStyles(Archive file, DocumentReader__PartPaths partPaths)
        {
            return ((tryParseOfficeXml(file, partPaths.getStyles())).map(new DocumentReader__Anonymous_10())).orElse(Styles._EMPTY);
        }

        public static Numbering readNumbering(Archive file, DocumentReader__PartPaths partPaths)
        {
            return ((tryParseOfficeXml(file, partPaths.getNumbering())).map(new DocumentReader__Anonymous_11())).orElse(Numbering._EMPTY);
        }

        public static ContentTypes readContentTypes(Archive file)
        {
            return ((tryParseOfficeXml(file, "[Content_Types].xml")).map(new DocumentReader__Anonymous_12())).orElse(ContentTypes._DEFAULT);
        }

        public static Relationships readRelationships(Archive zipFile, string name)
        {
            return ((tryParseOfficeXml(zipFile, name)).map(new DocumentReader__Anonymous_13())).orElse(Relationships._EMPTY);
        }

        public static string findRelationshipsPathFor(string name)
        {
            var parts = ZipPaths.splitPath(name);
            return ZipPaths.joinPath(new[] { parts.getDirname(), "_rels", parts.getBasename() + ".rels" });
        }

        public static Optional<XmlElement> tryParseOfficeXml(Archive zipFile, string name)
        {
            return PassThroughException.wrap(new DocumentReader__Anonymous_15(zipFile, name));
        }

        public static XmlElement parseOfficeXml(Archive zipFile, string name)
        {
            return (tryParseOfficeXml(zipFile, name)).orElseThrow(new DocumentReader__Anonymous_16(name));
        }
    }
}
