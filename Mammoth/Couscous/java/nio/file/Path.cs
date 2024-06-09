using Mammoth.Couscous.java.net;


namespace Mammoth.Couscous.java.nio.file {
    internal class Path {
        private readonly string _path;

        internal Path(string path)
        {
            _path = path;
        }

        internal Uri ToUri()
        {
            return new Uri(_path);
        }
    }
}
