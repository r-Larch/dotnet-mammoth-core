using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader {
        private ContentTypes _contentTypes;
        private IArchive _file;
        private IFileReader _fileReader;
        private Numbering _numbering;
        private Relationships _relationships;
        private Styles _styles;

        internal BodyXmlReader(Styles styles, Numbering numbering, Relationships relationships, ContentTypes contentTypes, IArchive file, IFileReader fileReader)
        {
            _styles = styles;
            _numbering = numbering;
            _relationships = relationships;
            _contentTypes = contentTypes;
            _file = file;
            _fileReader = fileReader;
        }

        public ReadResult ReadElements(ITerable<IXmlNode> nodes)
        {
            return (new StatefulBodyXmlReader(_styles, _numbering, _relationships, _contentTypes, _file, _fileReader)).ReadElements(nodes);
        }

        public ReadResult ReadElement(XmlElement element)
        {
            return (new StatefulBodyXmlReader(_styles, _numbering, _relationships, _contentTypes, _file, _fileReader)).ReadElement(element);
        }
    }
}
