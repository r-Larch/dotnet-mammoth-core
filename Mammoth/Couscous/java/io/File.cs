using Mammoth.Couscous.java.nio.file;


namespace Mammoth.Couscous.java.io {
    internal class File {
        internal File(string path)
        {
            Path = path;
        }

        public string Path { get; }

        internal Path toPath()
        {
            return new Path(Path);
        }
    }
}
