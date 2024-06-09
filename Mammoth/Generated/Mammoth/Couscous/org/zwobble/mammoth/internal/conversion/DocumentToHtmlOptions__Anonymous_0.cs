using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptionsAnonymous0(images.IImage image) : ISupplierWithException<INputStream, IoException> {
        public INputStream Get()
        {
            return image.GetInputStream();
        }
    }

    internal class DocumentToHtmlOptionsAnonymous1 : IMageConverterImgElement {
        public IMap<string, string> Convert(images.IImage image)
        {
            var base64 = Base64Encoding.StreamToBase64(new DocumentToHtmlOptionsAnonymous0(image));
            var src = $"data:{image.GetContentType()};base64,{base64}";
            return Maps.Map("src", src);
        }
    }
}
