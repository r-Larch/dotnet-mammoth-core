using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__PartWithBodyReader {
        internal ContentTypes _contentTypes;
        internal FileReader _fileReader;
        internal Numbering _numbering;
        internal Styles _styles;
        internal Archive _zipFile;

        internal DocumentReader__PartWithBodyReader(Archive zipFile, ContentTypes contentTypes, FileReader fileReader, Numbering numbering, Styles styles)
        {
            _zipFile = zipFile;
            _contentTypes = contentTypes;
            _fileReader = fileReader;
            _numbering = numbering;
            _styles = styles;
        }

        public T readPart<T>(string name, BiFunction<XmlElement, BodyXmlReader, T> readPart, Optional<T> defaultValue)
        {
            var relationships = DocumentReader.readRelationships(_zipFile, DocumentReader.findRelationshipsPathFor(name));
            var bodyReader = new BodyXmlReader(_styles, _numbering, relationships, _contentTypes, _zipFile, _fileReader);
            if (defaultValue.isPresent()) {
                return ((DocumentReader.tryParseOfficeXml(_zipFile, name)).map(new DocumentReader__Anonymous_17<T>(readPart, bodyReader))).orElse(defaultValue.get());
            }

            return readPart.apply(DocumentReader.parseOfficeXml(_zipFile, name), bodyReader);
        }
    }
}
