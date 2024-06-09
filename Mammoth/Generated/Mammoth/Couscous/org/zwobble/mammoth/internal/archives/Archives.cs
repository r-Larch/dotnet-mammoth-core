using Mammoth.Couscous.java.io;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class Archives {
        public static INputStream GetInputStream(IArchive file, string name)
        {
            return (file.TryGetInputStream(name)).OrElseThrow(new ArchivesAnonymous0(name));
        }
    }
}
