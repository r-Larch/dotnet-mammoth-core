using Mammoth.Couscous.java.io;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class Archives {
        public static InputStream getInputStream(Archive file, string name)
        {
            return (file.tryGetInputStream(name)).orElseThrow(new Archives__Anonymous_0(name));
        }
    }
}
