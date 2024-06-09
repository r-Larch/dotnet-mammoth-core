namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator;
        internal XmlParser__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator) {
            this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator = this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator;
        }
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName arg0) {
            return (this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator).readName(arg0);
        }
    }
}

