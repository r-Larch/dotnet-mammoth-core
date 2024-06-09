using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_17 : Function<List<DocumentElement>, DocumentElement> {
        internal int _colspan;
        internal XmlElementLike _properties;
        internal StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;

        internal StatefulBodyXmlReader__Anonymous_17(StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, XmlElementLike properties, int colspan)
        {
            _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            _properties = properties;
            _colspan = colspan;
        }

        public DocumentElement apply(List<DocumentElement> children)
        {
            return new StatefulBodyXmlReader__UnmergedTableCell((_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readVmerge(_properties), _colspan, children);
        }
    }
}
