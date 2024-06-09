using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixesBuilder {
        private readonly IMap<string, NamespacePrefix> _uriToPrefix = new HashMap<string, NamespacePrefix>();

        public NamespacePrefixesBuilder Put(string prefix, string uri)
        {
            _uriToPrefix.Put(uri, new NamespacePrefix(Optional.Of(prefix), uri));
            return this;
        }

        public NamespacePrefixesBuilder DefaultPrefix(string uri)
        {
            _uriToPrefix.Put(uri, new NamespacePrefix(Optional.Empty<string>(), uri));
            return this;
        }

        public NamespacePrefixes Build()
        {
            return new NamespacePrefixes(_uriToPrefix);
        }
    }
}
