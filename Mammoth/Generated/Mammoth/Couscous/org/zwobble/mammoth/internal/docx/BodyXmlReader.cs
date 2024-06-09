namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _relationships;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        internal BodyXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader) {
            this._styles = styles;
            this._numbering = numbering;
            this._relationships = relationships;
            this._contentTypes = contentTypes;
            this._file = file;
            this._fileReader = fileReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElements(Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> nodes) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader(this._styles, this._numbering, this._relationships, this._contentTypes, this._file, this._fileReader)).readElements(nodes);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader(this._styles, this._numbering, this._relationships, this._contentTypes, this._file, this._fileReader)).readElement(element);
        }
    }
}

