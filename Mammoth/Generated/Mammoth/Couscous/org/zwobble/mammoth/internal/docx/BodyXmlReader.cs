using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader {
        internal ContentTypes _contentTypes;
        internal Archive _file;
        internal FileReader _fileReader;
        internal Numbering _numbering;
        internal Relationships _relationships;
        internal Styles _styles;

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
