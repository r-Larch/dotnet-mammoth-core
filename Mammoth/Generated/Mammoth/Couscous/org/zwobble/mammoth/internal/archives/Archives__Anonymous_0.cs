using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class Archives__Anonymous_0 : Supplier<IOException> {
        private string _name;

        internal Archives__Anonymous_0(string name)
        {
            _name = name;
        }

        public IOException get()
        {
            return new IOException("Missing entry in file: " + _name);
        }
    }
}
