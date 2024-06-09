using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes__Builder {
        private Map<string, NamespacePrefix> _uriToPrefix;

        internal NamespacePrefixes__Builder()
        {
            _uriToPrefix = new HashMap<string, NamespacePrefix>();
        }

        public NamespacePrefixes__Builder put(string prefix, string uri)
        {
            (_uriToPrefix).put(uri, new NamespacePrefix(Optional.of(prefix), uri));
            return this;
        }

        public NamespacePrefixes__Builder defaultPrefix(string uri)
        {
            (_uriToPrefix).put(uri, new NamespacePrefix(Optional.empty<string>(), uri));
            return this;
        }

        public NamespacePrefixes build()
        {
            return new NamespacePrefixes(_uriToPrefix);
        }
    }
}
