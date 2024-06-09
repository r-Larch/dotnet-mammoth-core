using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous25 : IFunction<string, ReadResult> {
        private XmlElement _element;
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous25(XmlElement element, StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader)
        {
            _element = element;
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
        }

        public ReadResult Apply(string relationshipId)
        {
            var title = (_element).GetAttributeOrNone("o:title");
            var imagePath = (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).RelationshipIdToDocxPath(relationshipId);
            return (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).ReadImage(imagePath, title, new StatefulBodyXmlReaderAnonymous24(_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader, imagePath));
        }
    }
}
