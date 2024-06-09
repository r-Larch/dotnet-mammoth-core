namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_4 : Mammoth.Couscous.java.util.function.Predicate<string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _archive;
        internal DocumentReader__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive archive) {
            this._archive = archive;
        }
        public bool test(string arg0) {
            return (this._archive).exists(arg0);
        }
    }
}

