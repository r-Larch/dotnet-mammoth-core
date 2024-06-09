namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement {
        public Mammoth.Couscous.java.util.Map<string, string> convert(Mammoth.Couscous.org.zwobble.mammoth.images.Image image) {
            string base64 = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Base64Encoding.streamToBase64(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions__Anonymous_0(image));
            string src = (("data:" + image.getContentType()) + ";base64,") + base64;
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("src", src);
        }
    }
}

