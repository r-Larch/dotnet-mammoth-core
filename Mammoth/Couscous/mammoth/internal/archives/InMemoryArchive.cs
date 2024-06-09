using System.IO;
using Mammoth.Couscous.java.io;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class InMemoryArchive {
        internal static IArchive FromStream(INputStream stream)
        {
            var memoryStream = new MemoryStream();
            stream.Stream.CopyTo(memoryStream);
            return new ZippedArchive(memoryStream);
        }
    }
}
