using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous5 : IFunction<XmlElement, ReadResult> {
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous5(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
        }

        public ReadResult Apply(XmlElement arg0)
        {
            return (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).ReadElement(arg0);
        }
    }
}
