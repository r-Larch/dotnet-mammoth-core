using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions__Anonymous_1 : ImageConverter__ImgElement {
        public Map<string, string> convert(Image image)
        {
            var base64 = Base64Encoding.streamToBase64(new DocumentToHtmlOptions__Anonymous_0(image));
            var src = (("data:" + image.getContentType()) + ";base64,") + base64;
            return Maps.map("src", src);
        }
    }
}
