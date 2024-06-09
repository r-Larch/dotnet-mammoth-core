namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypes {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _DEFAULT;
        internal static Mammoth.Couscous.java.util.Map<string, string> _imageExtensions;
        internal Mammoth.Couscous.java.util.Map<string, string> _extensionDefaults;
        internal Mammoth.Couscous.java.util.Map<string, string> _overrides;
        static ContentTypes() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._DEFAULT = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._imageExtensions = ((((((((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.builder<string, string>()).put("png", "png")).put("gif", "gif")).put("jpeg", "jpeg")).put("jpg", "jpeg")).put("bmp", "bmp")).put("tif", "tiff")).put("tiff", "tiff")).build();
        }
        internal ContentTypes(Mammoth.Couscous.java.util.Map<string, string> extensionDefaults, Mammoth.Couscous.java.util.Map<string, string> overrides) {
            this._extensionDefaults = extensionDefaults;
            this._overrides = overrides;
        }
        public Mammoth.Couscous.java.util.Optional<string> findContentType(string path) {
            if ((this._overrides).containsKey(path)) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._overrides, path);
            } else {
                string extension = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Paths.getExtension(path);
                if ((this._extensionDefaults).containsKey(extension)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._extensionDefaults, extension);
                } else {
                    return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._imageExtensions, extension.ToLower())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes__Anonymous_0());
                }
            }
        }
    }
}

