using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous11 : IFunction<IList<IDocumentElement>, ReadResult> {
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous11(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
        }

        public ReadResult Apply(IList<IDocumentElement> arg0)
        {
            return (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).CalculateRowspans(arg0);
        }
    }
}
