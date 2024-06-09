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
        public static InternalResult<Document> ReadDocument(IOptional<Path> path, IArchive zipFile)
        {
            var partPaths = FindPartPaths(zipFile);
            var styles = ReadStyles(zipFile, partPaths);
            var numbering = ReadNumbering(zipFile, partPaths);
            var contentTypes = ReadContentTypes(zipFile);
            IFileReader fileReader = new PathRelativeFileReader(path);
            var partReader = new DocumentReaderPartWithBodyReader(zipFile, contentTypes, fileReader, numbering, styles);
            return InternalResult.FlatMap(ReadNotes(partReader, partPaths), ReadComments(partReader, partPaths), new DocumentReaderAnonymous1(partReader, partPaths));
        }

        public static DocumentReaderPartPaths FindPartPaths(IArchive archive)
        {
            var packageRelationships = ReadPackageRelationships(archive);
            var documentFilename = FindDocumentFilename(archive, packageRelationships);
            var documentRelationships = ReadRelationships(archive, FindRelationshipsPathFor(documentFilename));
            IFunction<string, string> find = new DocumentReaderAnonymous2(archive, documentRelationships, documentFilename);
            return new DocumentReaderPartPaths(documentFilename, find.Apply("comments"), find.Apply("endnotes"), find.Apply("footnotes"), find.Apply("numbering"), find.Apply("styles"));
        }

        public static Relationships ReadPackageRelationships(IArchive archive)
        {
            return ReadRelationships(archive, "_rels/.rels");
        }

        public static string FindDocumentFilename(IArchive archive, Relationships packageRelationships)
        {
            var officeDocumentType = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
            var mainDocumentPath = FindPartPath(archive, packageRelationships, officeDocumentType, "", "word/document.xml");
            if (archive.Exists(mainDocumentPath)) {
                return mainDocumentPath;
            }

            throw new PassThroughException(new IoException("Could not find main document part. Are you sure this is a valid .docx file?"));
        }

        public static string FindPartPath(IArchive archive, Relationships relationships, string relationshipType, string basePath, string fallbackPath)
        {
            var targets = Lists.EagerMap(relationships.FindTargetsByType(relationshipType), new DocumentReaderAnonymous3(basePath));
            var validTargets = Lists.EagerFilter(targets, new DocumentReaderAnonymous4(archive));
            return Lists.TryGetFirst(validTargets).OrElse(fallbackPath);
        }

        public static InternalResult<IList<Comment>> ReadComments(DocumentReaderPartWithBodyReader partReader, DocumentReaderPartPaths partPaths)
        {
            return partReader.ReadPart(partPaths.GetComments(), new DocumentReaderAnonymous5(), Optional.Of(InternalResult.Success(Lists.List<Comment>())));
        }

        public static InternalResult<Notes> ReadNotes(DocumentReaderPartWithBodyReader partReader, DocumentReaderPartPaths partPaths)
        {
            return InternalResult.Map(partReader.ReadPart(partPaths.GetFootnotes(), new DocumentReaderAnonymous6(), Optional.Of(InternalResult.Success(Lists.List<Note>()))), partReader.ReadPart(partPaths.GetEndnotes(), new DocumentReaderAnonymous7(), Optional.Of(InternalResult.Success(Lists.List<Note>()))), new DocumentReaderAnonymous8()).Map(new DocumentReaderAnonymous9());
        }

        public static Styles ReadStyles(IArchive file, DocumentReaderPartPaths partPaths)
        {
            return TryParseOfficeXml(file, partPaths.GetStyles()).Map(new DocumentReaderAnonymous10()).OrElse(Styles.Empty);
        }

        public static Numbering ReadNumbering(IArchive file, DocumentReaderPartPaths partPaths)
        {
            return TryParseOfficeXml(file, partPaths.GetNumbering()).Map(new DocumentReaderAnonymous11()).OrElse(Numbering.Empty);
        }

        public static ContentTypes ReadContentTypes(IArchive file)
        {
            return TryParseOfficeXml(file, "[Content_Types].xml").Map(new DocumentReaderAnonymous12()).OrElse(ContentTypes.Default);
        }

        public static Relationships ReadRelationships(IArchive zipFile, string name)
        {
            return TryParseOfficeXml(zipFile, name).Map(new DocumentReaderAnonymous13()).OrElse(Relationships.Empty);
        }

        public static string FindRelationshipsPathFor(string name)
        {
            var parts = ZipPaths.SplitPath(name);
            return ZipPaths.JoinPath([parts.GetDirname(), "_rels", $"{parts.GetBasename()}.rels"]);
        }

        public static IOptional<XmlElement> TryParseOfficeXml(IArchive zipFile, string name)
        {
            return PassThroughException.Wrap(new DocumentReaderAnonymous15(zipFile, name));
        }

        public static XmlElement ParseOfficeXml(IArchive zipFile, string name)
        {
            return TryParseOfficeXml(zipFile, name).OrElseThrow(new DocumentReaderAnonymous16(name));
        }
    }
}
