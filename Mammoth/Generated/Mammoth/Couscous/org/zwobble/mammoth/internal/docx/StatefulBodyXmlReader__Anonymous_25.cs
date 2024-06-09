using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_25 : Function<string, ReadResult> {
        internal XmlElement _element;
        internal StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;

        internal StatefulBodyXmlReader__Anonymous_25(XmlElement element, StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)
        {
            _element = element;
            _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }

        public ReadResult apply(string relationshipId)
        {
            var title = (_element).getAttributeOrNone("o:title");
            var imagePath = (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).relationshipIdToDocxPath(relationshipId);
            return (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readImage(imagePath, title, new StatefulBodyXmlReader__Anonymous_24(_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, imagePath));
        }
    }
}
