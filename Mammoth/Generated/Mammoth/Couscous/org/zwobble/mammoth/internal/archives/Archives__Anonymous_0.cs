namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class Archives__Anonymous_0 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.io.IOException> {
        internal string _name;
        internal Archives__Anonymous_0(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.io.IOException get() {
            return new Mammoth.Couscous.java.io.IOException("Missing entry in file: " + this._name);
        }
    }
}

