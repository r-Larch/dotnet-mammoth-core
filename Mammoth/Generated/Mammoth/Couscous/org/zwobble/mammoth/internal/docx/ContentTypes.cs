using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypes(
        IMap<string, string> extensionDefaults,
        IMap<string, string> overrides
    ) {
        public static ContentTypes Default = new(Maps.Map<string, string>(), Maps.Map<string, string>());
        private static readonly IMap<string, string> ImageExtensions = Maps.Builder<string, string>().Put("png", "png").Put("gif", "gif").Put("jpeg", "jpeg").Put("jpg", "jpeg").Put("bmp", "bmp").Put("tif", "tiff").Put("tiff", "tiff").Build();

        public IOptional<string> FindContentType(string path)
        {
            if (overrides.ContainsKey(path)) {
                return Maps.Lookup(overrides, path);
            }

            var extension = Paths.GetExtension(path);
            if (extensionDefaults.ContainsKey(extension)) {
                return Maps.Lookup(extensionDefaults, extension);
            }

            return Maps.Lookup(ImageExtensions, extension.ToLower()).Map(new ContentTypesAnonymous0());
        }
    }
}
