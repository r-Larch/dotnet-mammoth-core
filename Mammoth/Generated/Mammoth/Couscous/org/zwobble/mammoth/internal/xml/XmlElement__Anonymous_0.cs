using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement__Anonymous_0 : Supplier<RuntimeException> {
        internal string _name;

        internal XmlElement__Anonymous_0(string name)
        {
            _name = name;
        }

        public RuntimeException get()
        {
            return new RuntimeException(("Element has no '" + _name) + "' attribute");
        }
    }
}
