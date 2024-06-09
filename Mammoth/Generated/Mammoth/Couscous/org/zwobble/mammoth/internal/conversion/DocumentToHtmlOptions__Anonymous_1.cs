using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptionsAnonymous1 : IMageConverterImgElement {
        public IMap<string, string> Convert(IMage image)
        {
            var base64 = Base64Encoding.StreamToBase64(new DocumentToHtmlOptionsAnonymous0(image));
            var src = (("data:" + image.GetContentType()) + ";base64,") + base64;
            return Maps.Map("src", src);
        }
    }
}
