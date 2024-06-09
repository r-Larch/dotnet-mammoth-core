using Mammoth.Couscous.java.io;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser {
        internal NamespacePrefixes _namespaces;

        internal XmlParser(NamespacePrefixes namespaces)
        {
            _namespaces = namespaces;
        }

        public XmlElement parseStream(InputStream inputStream)
        {
            var nodeGenerator = create_NodeGenerator();
            SimpleSax.parseStream(inputStream, nodeGenerator);
            return nodeGenerator.getRoot();
        }

        public XmlElement parseString(string value)
        {
            var nodeGenerator = create_NodeGenerator();
            SimpleSax.parseString(value, nodeGenerator);
            return nodeGenerator.getRoot();
        }

        public XmlParser__NodeGenerator create_NodeGenerator()
        {
            return new XmlParser__NodeGenerator(this);
        }
    }
}
