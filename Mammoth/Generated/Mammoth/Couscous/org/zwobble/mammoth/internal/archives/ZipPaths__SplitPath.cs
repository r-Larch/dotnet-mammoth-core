namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPathsSplitPath {
        private string _basename;
        private string _dirname;

        internal ZipPathsSplitPath(string dirname, string basename)
        {
            _dirname = dirname;
            _basename = basename;
        }

        public string GetDirname()
        {
            return _dirname;
        }

        public string GetBasename()
        {
            return _basename;
        }
    }
}
