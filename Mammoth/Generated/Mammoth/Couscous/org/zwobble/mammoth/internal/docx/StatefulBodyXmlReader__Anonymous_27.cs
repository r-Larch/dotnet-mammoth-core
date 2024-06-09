using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous27 : IFunction<XmlElement, ReadResult> {
        private IOptional<string> _altText;
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous27(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader, IOptional<string> altText)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
            _altText = altText;
        }

        public ReadResult Apply(XmlElement blip)
        {
            return (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).ReadBlip(blip, _altText);
        }
    }
}
