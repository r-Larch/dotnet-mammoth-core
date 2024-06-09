using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParserAnonymous0 : IFunction<ElementName, string> {
        private XmlParserNodeGenerator _thisOrgZwobbleMammothInternalXmlParsingXmlParserNodeGenerator;

        internal XmlParserAnonymous0(XmlParserNodeGenerator thisOrgZwobbleMammothInternalXmlParsingXmlParserNodeGenerator)
        {
            _thisOrgZwobbleMammothInternalXmlParsingXmlParserNodeGenerator = thisOrgZwobbleMammothInternalXmlParsingXmlParserNodeGenerator;
        }

        public string Apply(ElementName arg0)
        {
            return (_thisOrgZwobbleMammothInternalXmlParsingXmlParserNodeGenerator).ReadName(arg0);
        }
    }
}
