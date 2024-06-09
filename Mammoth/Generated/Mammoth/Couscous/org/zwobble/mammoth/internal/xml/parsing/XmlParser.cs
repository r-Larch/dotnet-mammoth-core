using Mammoth.Couscous.java.io;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser {
        public NamespacePrefixes Namespaces;

        internal XmlParser(NamespacePrefixes namespaces)
        {
            Namespaces = namespaces;
        }

        public XmlElement ParseStream(INputStream inputStream)
        {
            var nodeGenerator = create_NodeGenerator();
            SimpleSax.ParseStream(inputStream, nodeGenerator);
            return nodeGenerator.GetRoot();
        }

        public XmlElement ParseString(string value)
        {
            var nodeGenerator = create_NodeGenerator();
            SimpleSax.ParseString(value, nodeGenerator);
            return nodeGenerator.GetRoot();
        }

        public XmlParserNodeGenerator create_NodeGenerator()
        {
            return new XmlParserNodeGenerator(this);
        }
    }
}
