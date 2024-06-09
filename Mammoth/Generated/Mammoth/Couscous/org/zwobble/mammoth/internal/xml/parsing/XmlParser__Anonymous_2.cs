namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix, string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName _name;
        internal XmlParser__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            this._name = name;
        }
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix @namespace) {
            return ((@namespace.getPrefix()).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__Anonymous_1())).orElse("") + (this._name).getLocalName();
        }
    }
}

