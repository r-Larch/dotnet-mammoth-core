using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes__Anonymous_0 : Predicate<NamespacePrefix> {
        private Optional<string> _prefix;

        internal NamespacePrefixes__Anonymous_0(Optional<string> prefix)
        {
            _prefix = prefix;
        }

        public bool test(NamespacePrefix @namespace)
        {
            return (@namespace.getPrefix()).equals(_prefix);
        }
    }
}
