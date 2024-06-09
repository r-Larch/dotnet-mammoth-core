using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixesAnonymous0(IOptional<string> prefix) : IPredicate<NamespacePrefix> {
        public bool Test(NamespacePrefix @namespace)
        {
            return @namespace.GetPrefix().Equals(prefix);
        }
    }
}
