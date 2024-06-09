using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class Archives {
        public static INputStream GetInputStream(IArchive file, string name)
        {
            return file.TryGetInputStream(name).OrElseThrow(new ArchivesAnonymous0(name));
        }
    }

    internal class ArchivesAnonymous0(string name) : ISupplier<IoException> {
        public IoException Get()
        {
            return new IoException($"Missing entry in file: {name}");
        }
    }
}
