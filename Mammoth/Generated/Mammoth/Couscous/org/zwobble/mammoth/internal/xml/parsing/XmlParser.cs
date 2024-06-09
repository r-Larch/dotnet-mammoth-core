namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _namespaces;
        internal XmlParser(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes namespaces) {
            this._namespaces = namespaces;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseStream(Mammoth.Couscous.java.io.InputStream inputStream) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator nodeGenerator = this.create_NodeGenerator();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.SimpleSax.parseStream(inputStream, nodeGenerator);
            return nodeGenerator.getRoot();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseString(string value) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator nodeGenerator = this.create_NodeGenerator();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.SimpleSax.parseString(value, nodeGenerator);
            return nodeGenerator.getRoot();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator create_NodeGenerator() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator(this);
        }
    }
}

