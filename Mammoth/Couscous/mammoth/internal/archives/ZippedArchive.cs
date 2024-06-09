using System.IO;
using System.IO.Compression;
using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using File = Mammoth.Couscous.java.io.File;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZippedArchive : IArchive {
        private readonly ZipArchive _zipFile;

        internal ZippedArchive(File file)
        {
            _zipFile = ZipFile.OpenRead(file.Path);
        }

        internal ZippedArchive(Stream stream)
        {
            _zipFile = new ZipArchive(stream);
        }

        public IOptional<INputStream> TryGetInputStream(string name)
        {
            var entry = _zipFile.GetEntry(name);
            if (entry == null) {
                return Optional.Empty<INputStream>();
            }

            return Optional.Of(ToJava.StreamToInputStream(entry.Open()));
        }

        public bool Exists(string name)
        {
            return _zipFile.GetEntry(name) != null;
        }

        public void Close()
        {
            _zipFile.Dispose();
        }
    }
}
