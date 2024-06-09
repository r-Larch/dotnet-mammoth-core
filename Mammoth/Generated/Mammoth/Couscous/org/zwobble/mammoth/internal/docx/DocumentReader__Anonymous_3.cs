namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal string _basePath;
        internal DocumentReader__Anonymous_3(string basePath) {
            this._basePath = basePath;
        }
        public string apply(string target) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.trimLeft(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths.joinPath(new string[] {this._basePath, target}), '/');
        }
    }
}

