namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths__SplitPath {
        internal string _dirname;
        internal string _basename;
        internal ZipPaths__SplitPath(string dirname, string basename) {
            this._dirname = dirname;
            this._basename = basename;
        }
        public string getDirname() {
            return this._dirname;
        }
        public string getBasename() {
            return this._basename;
        }
    }
}

