using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes(IMap<string, NamespacePrefix> uriToPrefix) : ITerable<NamespacePrefix> {
        public ITerator<NamespacePrefix> Iterator()
        {
            return uriToPrefix.Values().Iterator();
        }

        public static NamespacePrefixesBuilder Builder()
        {
            return new NamespacePrefixesBuilder();
        }

        public IOptional<NamespacePrefix> LookupUri(string uri)
        {
            return Maps.Lookup(uriToPrefix, uri);
        }

        public IOptional<NamespacePrefix> LookupPrefix(string prefix)
        {
            return LookupPrefix(Optional.Of(prefix));
        }

        public IOptional<NamespacePrefix> DefaultNamespace()
        {
            return LookupPrefix(Optional.Empty<string>());
        }

        public IOptional<NamespacePrefix> LookupPrefix(IOptional<string> prefix)
        {
            return Iterables.TryFind(uriToPrefix.Values(), new NamespacePrefixesAnonymous0(prefix));
        }
    }
}
