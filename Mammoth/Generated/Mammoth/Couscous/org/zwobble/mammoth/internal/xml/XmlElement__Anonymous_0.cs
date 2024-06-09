using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementAnonymous0 : ISupplier<RuntimeException> {
        private string _name;

        internal XmlElementAnonymous0(string name)
        {
            _name = name;
        }

        public RuntimeException Get()
        {
            return new RuntimeException(("Element has no '" + _name) + "' attribute");
        }
    }
}
