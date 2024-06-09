namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal interface Archive : Mammoth.Couscous.java.io.Closeable {
        Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.io.InputStream> tryGetInputStream(string name);
        bool exists(string name);
    }
}

