namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__PartWithBodyReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal DocumentReader__PartWithBodyReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles) {
            this._zipFile = zipFile;
            this._contentTypes = contentTypes;
            this._fileReader = fileReader;
            this._numbering = numbering;
            this._styles = styles;
        }
        public T readPart<T>(string name, Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, T> readPart, Mammoth.Couscous.java.util.Optional<T> defaultValue) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readRelationships(this._zipFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.findRelationshipsPathFor(name));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader(this._styles, this._numbering, relationships, this._contentTypes, this._zipFile, this._fileReader);
            if (defaultValue.isPresent()) {
                return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(this._zipFile, name)).map<T>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_17<T>(readPart, bodyReader))).orElse(defaultValue.get());
            } else {
                return readPart.apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.parseOfficeXml(this._zipFile, name), bodyReader);
            }
        }
    }
}

