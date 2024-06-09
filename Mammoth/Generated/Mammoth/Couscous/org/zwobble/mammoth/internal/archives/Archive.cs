using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal interface IArchive : ICloseable {
        IOptional<INputStream> TryGetInputStream(string name);
        bool Exists(string name);
    }
}
