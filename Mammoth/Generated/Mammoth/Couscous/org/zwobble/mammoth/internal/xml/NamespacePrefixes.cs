using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes : Iterable<NamespacePrefix> {
        private Map<string, NamespacePrefix> _uriToPrefix;

        internal NamespacePrefixes(Map<string, NamespacePrefix> uriToPrefix)
        {
            _uriToPrefix = uriToPrefix;
        }

        public Iterator<NamespacePrefix> iterator()
        {
            return ((_uriToPrefix).values()).iterator();
        }

        public static NamespacePrefixes__Builder builder()
        {
            return new NamespacePrefixes__Builder();
        }

        public Optional<NamespacePrefix> lookupUri(string uri)
        {
            return Maps.lookup(_uriToPrefix, uri);
        }

        public Optional<NamespacePrefix> lookupPrefix(string prefix)
        {
            return lookupPrefix(Optional.of(prefix));
        }

        public Optional<NamespacePrefix> defaultNamespace()
        {
            return lookupPrefix(Optional.empty<string>());
        }

        public Optional<NamespacePrefix> lookupPrefix(Optional<string> prefix)
        {
            return Iterables.tryFind((_uriToPrefix).values(), new NamespacePrefixes__Anonymous_0(prefix));
        }
    }
}
