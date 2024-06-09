using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_0 : Function<ElementName, string> {
        internal XmlParser__NodeGenerator _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator;

        internal XmlParser__Anonymous_0(XmlParser__NodeGenerator this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator)
        {
            _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator = this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator;
        }

        public string apply(ElementName arg0)
        {
            return (_this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator).readName(arg0);
        }
    }
}
