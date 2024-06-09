using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader(Styles styles, Numbering numbering, Relationships relationships, ContentTypes contentTypes, IArchive file, IFileReader fileReader) {
        public ReadResult ReadElements(ITerable<IXmlNode> nodes)
        {
            return new StatefulBodyXmlReader(styles, numbering, relationships, contentTypes, file, fileReader).ReadElements(nodes);
        }

        public ReadResult ReadElement(XmlElement element)
        {
            return new StatefulBodyXmlReader(styles, numbering, relationships, contentTypes, file, fileReader).ReadElement(element);
        }
    }
}
