namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Style__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal string _styleIdDescription;
        internal Style__Anonymous_0(string styleIdDescription) {
            this._styleIdDescription = styleIdDescription;
        }
        public string apply(string name) {
            return ((name + " (") + this._styleIdDescription) + ")";
        }
    }
}

