using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader {
        private ContentTypes _contentTypes;
        private Archive _file;
        private FileReader _fileReader;
        private Numbering _numbering;
        private Relationships _relationships;
        private Styles _styles;

        internal BodyXmlReader(Styles styles, Numbering numbering, Relationships relationships, ContentTypes contentTypes, Archive file, FileReader fileReader)
        {
            _styles = styles;
            _numbering = numbering;
            _relationships = relationships;
            _contentTypes = contentTypes;
            _file = file;
            _fileReader = fileReader;
        }

        public ReadResult readElements(Iterable<XmlNode> nodes)
        {
            return (new StatefulBodyXmlReader(_styles, _numbering, _relationships, _contentTypes, _file, _fileReader)).readElements(nodes);
        }

        public ReadResult readElement(XmlElement element)
        {
            return (new StatefulBodyXmlReader(_styles, _numbering, _relationships, _contentTypes, _file, _fileReader)).readElement(element);
        }
    }
}
