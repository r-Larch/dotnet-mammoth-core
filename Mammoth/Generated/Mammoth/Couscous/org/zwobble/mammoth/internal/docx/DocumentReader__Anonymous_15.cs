namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_15 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal string _name;
        internal DocumentReader__Anonymous_15(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            this._zipFile = zipFile;
            this._name = name;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> get() {
            return ((this._zipFile).tryGetInputStream(this._name)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_14());
        }
    }
}

