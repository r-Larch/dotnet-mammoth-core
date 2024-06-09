using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderPartWithBodyReader {
        private ContentTypes _contentTypes;
        private IFileReader _fileReader;
        private Numbering _numbering;
        private Styles _styles;
        private IArchive _zipFile;

        internal DocumentReaderPartWithBodyReader(IArchive zipFile, ContentTypes contentTypes, IFileReader fileReader, Numbering numbering, Styles styles)
        {
            _zipFile = zipFile;
            _contentTypes = contentTypes;
            _fileReader = fileReader;
            _numbering = numbering;
            _styles = styles;
        }

        public T ReadPart<T>(string name, IBiFunction<XmlElement, BodyXmlReader, T> readPart, IOptional<T> defaultValue)
        {
            var relationships = DocumentReader.ReadRelationships(_zipFile, DocumentReader.FindRelationshipsPathFor(name));
            var bodyReader = new BodyXmlReader(_styles, _numbering, relationships, _contentTypes, _zipFile, _fileReader);
            if (defaultValue.IsPresent()) {
                return ((DocumentReader.TryParseOfficeXml(_zipFile, name)).Map(new DocumentReaderAnonymous17<T>(readPart, bodyReader))).OrElse(defaultValue.Get());
            }

            return readPart.Apply(DocumentReader.ParseOfficeXml(_zipFile, name), bodyReader);
        }
    }
}
