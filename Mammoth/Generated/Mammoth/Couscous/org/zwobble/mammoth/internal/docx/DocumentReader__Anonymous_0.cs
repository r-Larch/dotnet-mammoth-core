using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous0(Notes notes, IList<Comment> comments) : IBiFunction<XmlElement, BodyXmlReader, InternalResult<Document>> {
        public InternalResult<Document> Apply(XmlElement element, BodyXmlReader bodyReader)
        {
            return new DocumentXmlReader(bodyReader, notes, comments).ReadElement(element);
        }
    }

    internal class DocumentReaderAnonymous1(DocumentReaderPartWithBodyReader partReader, DocumentReaderPartPaths partPaths) : IBiFunction<Notes, IList<Comment>, InternalResult<Document>> {
        public InternalResult<Document> Apply(Notes notes, IList<Comment> comments)
        {
            return partReader.ReadPart(partPaths.GetMainDocument(), new DocumentReaderAnonymous0(notes, comments), Optional.Empty<InternalResult<Document>>());
        }
    }

    internal class DocumentReaderAnonymous10 : IFunction<XmlElement, Styles> {
        public Styles Apply(XmlElement arg0)
        {
            return StylesXml.ReadStylesXmlElement(arg0);
        }
    }

    internal class DocumentReaderAnonymous11 : IFunction<XmlElement, Numbering> {
        public Numbering Apply(XmlElement arg0)
        {
            return NumberingXml.ReadNumberingXmlElement(arg0);
        }
    }

    internal class DocumentReaderAnonymous12 : IFunction<XmlElement, ContentTypes> {
        public ContentTypes Apply(XmlElement arg0)
        {
            return ContentTypesXml.ReadContentTypesXmlElement(arg0);
        }
    }

    internal class DocumentReaderAnonymous13 : IFunction<XmlElement, Relationships> {
        public Relationships Apply(XmlElement arg0)
        {
            return RelationshipsXml.ReadRelationshipsXmlElement(arg0);
        }
    }

    internal class DocumentReaderAnonymous14 : IFunction<INputStream, XmlElement> {
        public XmlElement Apply(INputStream arg0)
        {
            return OfficeXml.ParseXml(arg0);
        }
    }

    internal class DocumentReaderAnonymous15(IArchive zipFile, string name) : ISupplierWithException<IOptional<XmlElement>, IoException> {
        public IOptional<XmlElement> Get()
        {
            return zipFile.TryGetInputStream(name).Map(new DocumentReaderAnonymous14());
        }
    }

    internal class DocumentReaderAnonymous16(string name) : ISupplier<PassThroughException> {
        public PassThroughException Get()
        {
            return new PassThroughException(new IoException($"Missing entry in file: {name}"));
        }
    }

    internal static class DocumentReaderAnonymous17 {
    }

    internal class DocumentReaderAnonymous17<T>(IBiFunction<XmlElement, BodyXmlReader, T> readPart, BodyXmlReader bodyReader) : IFunction<XmlElement, T> {
        public T Apply(XmlElement root)
        {
            return readPart.Apply(root, bodyReader);
        }
    }

    internal class DocumentReaderAnonymous2(IArchive archive, Relationships documentRelationships, string documentFilename) : IFunction<string, string> {
        public string Apply(string name)
        {
            return DocumentReader.FindPartPath(archive, documentRelationships, $"http://schemas.openxmlformats.org/officeDocument/2006/relationships/{name}", ZipPaths.SplitPath(documentFilename).GetDirname(), $"word/{name}.xml");
        }
    }

    internal class DocumentReaderAnonymous3(string basePath) : IFunction<string, string> {
        public string Apply(string target)
        {
            return Strings.TrimLeft(ZipPaths.JoinPath([basePath, target]), '/');
        }
    }

    internal class DocumentReaderAnonymous4(IArchive archive) : IPredicate<string> {
        public bool Test(string arg0)
        {
            return archive.Exists(arg0);
        }
    }

    internal class DocumentReaderAnonymous5 : IBiFunction<XmlElement, BodyXmlReader, InternalResult<IList<Comment>>> {
        public InternalResult<IList<Comment>> Apply(XmlElement root, BodyXmlReader bodyReader)
        {
            return new CommentXmlReader(bodyReader).ReadElement(root);
        }
    }

    internal class DocumentReaderAnonymous6 : IBiFunction<XmlElement, BodyXmlReader, InternalResult<IList<Note>>> {
        public InternalResult<IList<Note>> Apply(XmlElement root, BodyXmlReader bodyReader)
        {
            return NotesXmlReader.Footnote(bodyReader).ReadElement(root);
        }
    }

    internal class DocumentReaderAnonymous7 : IBiFunction<XmlElement, BodyXmlReader, InternalResult<IList<Note>>> {
        public InternalResult<IList<Note>> Apply(XmlElement root, BodyXmlReader bodyReader)
        {
            return NotesXmlReader.Endnote(bodyReader).ReadElement(root);
        }
    }

    internal class DocumentReaderAnonymous8 : IBiFunction<IList<Note>, IList<Note>, IList<Note>> {
        public IList<Note> Apply(IList<Note> arg0, IList<Note> arg1)
        {
            return Lists.EagerConcat(arg0, arg1);
        }
    }

    internal class DocumentReaderAnonymous9 : IFunction<IList<Note>, Notes> {
        public Notes Apply(IList<Note> arg0)
        {
            return new Notes(arg0);
        }
    }

    internal class DocumentReaderPartPaths(string mainDocument, string comments, string endnotes, string footnotes, string numbering, string styles) {
        public string GetMainDocument()
        {
            return mainDocument;
        }

        public string GetComments()
        {
            return comments;
        }

        public string GetEndnotes()
        {
            return endnotes;
        }

        public string GetFootnotes()
        {
            return footnotes;
        }

        public string GetNumbering()
        {
            return numbering;
        }

        public string GetStyles()
        {
            return styles;
        }
    }

    internal class DocumentReaderPartWithBodyReader(IArchive zipFile, ContentTypes contentTypes, IFileReader fileReader, Numbering numbering, Styles styles) {
        public T ReadPart<T>(string name, IBiFunction<XmlElement, BodyXmlReader, T> readPart, IOptional<T> defaultValue)
        {
            var relationships = DocumentReader.ReadRelationships(zipFile, DocumentReader.FindRelationshipsPathFor(name));
            var bodyReader = new BodyXmlReader(styles, numbering, relationships, contentTypes, zipFile, fileReader);
            if (defaultValue.IsPresent()) {
                return DocumentReader.TryParseOfficeXml(zipFile, name).Map(new DocumentReaderAnonymous17<T>(readPart, bodyReader)).OrElse(defaultValue.Get());
            }

            return readPart.Apply(DocumentReader.ParseOfficeXml(zipFile, name), bodyReader);
        }
    }
}
