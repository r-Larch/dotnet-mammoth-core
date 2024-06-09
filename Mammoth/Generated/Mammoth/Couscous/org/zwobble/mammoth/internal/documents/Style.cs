namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Style {
        internal string _styleId;
        internal Mammoth.Couscous.java.util.Optional<string> _name;
        internal Style(string styleId, Mammoth.Couscous.java.util.Optional<string> name) {
            this._styleId = styleId;
            this._name = name;
        }
        public string getStyleId() {
            return this._styleId;
        }
        public Mammoth.Couscous.java.util.Optional<string> getName() {
            return this._name;
        }
        public string describe() {
            string styleIdDescription = "Style ID: " + this._styleId;
            return ((this._name).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style__Anonymous_0(styleIdDescription))).orElse(styleIdDescription);
        }
    }
}

