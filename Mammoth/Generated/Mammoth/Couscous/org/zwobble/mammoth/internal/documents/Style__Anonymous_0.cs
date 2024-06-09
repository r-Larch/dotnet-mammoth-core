using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Style__Anonymous_0 : Function<string, string> {
        internal string _styleIdDescription;

        internal Style__Anonymous_0(string styleIdDescription)
        {
            _styleIdDescription = styleIdDescription;
        }

        public string apply(string name)
        {
            return ((name + " (") + _styleIdDescription) + ")";
        }
    }
}
