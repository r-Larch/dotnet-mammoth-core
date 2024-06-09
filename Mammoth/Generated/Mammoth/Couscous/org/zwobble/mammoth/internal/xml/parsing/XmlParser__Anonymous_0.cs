using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParserAnonymous0(XmlParserNodeGenerator generator) : IFunction<ElementName, string> {
        public string Apply(ElementName arg0)
        {
            return generator.ReadName(arg0);
        }
    }

    internal class XmlParserAnonymous1 : IFunction<string, string> {
        public string Apply(string prefix)
        {
            return $"{prefix}:";
        }
    }

    internal class XmlParserAnonymous2(ElementName name) : IFunction<NamespacePrefix, string> {
        public string Apply(NamespacePrefix @namespace)
        {
            return @namespace.GetPrefix().Map(new XmlParserAnonymous1()).OrElse("") + name.GetLocalName();
        }
    }

    internal class XmlParserAnonymous3(ElementName name) : ISupplier<string> {
        public string Get()
        {
            return $"{{{name.GetUri()}}}{name.GetLocalName()}";
        }
    }
}
