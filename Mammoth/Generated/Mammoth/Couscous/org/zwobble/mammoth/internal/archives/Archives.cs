namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class Archives {
        public static Mammoth.Couscous.java.io.InputStream getInputStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, string name) {
            return (file.tryGetInputStream(name)).orElseThrow<Mammoth.Couscous.java.io.IOException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives__Anonymous_0(name));
        }
    }
}

