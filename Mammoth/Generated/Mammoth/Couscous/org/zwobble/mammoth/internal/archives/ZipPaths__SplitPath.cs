namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths__SplitPath {
        private string _basename;
        private string _dirname;

        internal ZipPaths__SplitPath(string dirname, string basename)
        {
            _dirname = dirname;
            _basename = basename;
        }

        public string getDirname()
        {
            return _dirname;
        }

        public string getBasename()
        {
            return _basename;
        }
    }
}
