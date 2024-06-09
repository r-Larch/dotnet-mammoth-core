using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous17 : IFunction<IList<IDocumentElement>, IDocumentElement> {
        private int _colspan;
        private IXmlElementLike _properties;
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous17(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader, IXmlElementLike properties, int colspan)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
            _properties = properties;
            _colspan = colspan;
        }

        public IDocumentElement Apply(IList<IDocumentElement> children)
        {
            return new StatefulBodyXmlReaderUnmergedTableCell((_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).ReadVmerge(_properties), _colspan, children);
        }
    }
}
