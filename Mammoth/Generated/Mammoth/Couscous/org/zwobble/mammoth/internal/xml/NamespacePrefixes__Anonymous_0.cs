using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixesAnonymous0 : IPredicate<NamespacePrefix> {
        private IOptional<string> _prefix;

        internal NamespacePrefixesAnonymous0(IOptional<string> prefix)
        {
            _prefix = prefix;
        }

        public bool Test(NamespacePrefix @namespace)
        {
            return @namespace.GetPrefix().Equals(_prefix);
        }
    }
}
