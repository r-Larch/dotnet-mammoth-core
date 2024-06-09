using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypes {
        public static ContentTypes _DEFAULT;
        private static Map<string, string> _imageExtensions;
        private Map<string, string> _extensionDefaults;
        private Map<string, string> _overrides;

        static ContentTypes()
        {
            _DEFAULT = new ContentTypes(Maps.map<string, string>(), Maps.map<string, string>());
            _imageExtensions = ((((((((Maps.builder<string, string>()).put("png", "png")).put("gif", "gif")).put("jpeg", "jpeg")).put("jpg", "jpeg")).put("bmp", "bmp")).put("tif", "tiff")).put("tiff", "tiff")).build();
        }

        internal ContentTypes(Map<string, string> extensionDefaults, Map<string, string> overrides)
        {
            _extensionDefaults = extensionDefaults;
            _overrides = overrides;
        }

        public Optional<string> findContentType(string path)
        {
            if ((_overrides).containsKey(path)) {
                return Maps.lookup(_overrides, path);
            }

            var extension = Paths.getExtension(path);
            if ((_extensionDefaults).containsKey(extension)) {
                return Maps.lookup(_extensionDefaults, extension);
            }

            return (Maps.lookup(_imageExtensions, extension.ToLower())).map(new ContentTypes__Anonymous_0());
        }
    }
}
