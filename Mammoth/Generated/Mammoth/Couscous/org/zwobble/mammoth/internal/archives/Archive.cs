using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal interface Archive : Closeable {
        Optional<InputStream> tryGetInputStream(string name);
        bool exists(string name);
    }
}
