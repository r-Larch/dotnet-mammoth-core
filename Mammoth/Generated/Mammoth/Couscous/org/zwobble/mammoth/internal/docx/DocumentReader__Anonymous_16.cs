namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_16 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException> {
        internal string _name;
        internal DocumentReader__Anonymous_16(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException get() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException(new Mammoth.Couscous.java.io.IOException("Missing entry in file: " + this._name));
        }
    }
}

