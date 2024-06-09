using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypes {
        public static ContentTypes Default;
        private static IMap<string, string> _imageExtensions;
        private IMap<string, string> _extensionDefaults;
        private IMap<string, string> _overrides;

        static ContentTypes()
        {
            Default = new ContentTypes(Maps.Map<string, string>(), Maps.Map<string, string>());
            _imageExtensions = ((((((((Maps.Builder<string, string>()).Put("png", "png")).Put("gif", "gif")).Put("jpeg", "jpeg")).Put("jpg", "jpeg")).Put("bmp", "bmp")).Put("tif", "tiff")).Put("tiff", "tiff")).Build();
        }

        internal ContentTypes(IMap<string, string> extensionDefaults, IMap<string, string> overrides)
        {
            _extensionDefaults = extensionDefaults;
            _overrides = overrides;
        }

        public IOptional<string> FindContentType(string path)
        {
            if ((_overrides).ContainsKey(path)) {
                return Maps.Lookup(_overrides, path);
            }

            var extension = Paths.GetExtension(path);
            if ((_extensionDefaults).ContainsKey(extension)) {
                return Maps.Lookup(_extensionDefaults, extension);
            }

            return (Maps.Lookup(_imageExtensions, extension.ToLower())).Map(new ContentTypesAnonymous0());
        }
    }
}
