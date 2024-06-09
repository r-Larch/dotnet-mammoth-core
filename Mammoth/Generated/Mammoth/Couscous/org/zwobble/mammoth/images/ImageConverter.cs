using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.images {
    internal interface IImage {
        IOptional<string> GetAltText();
        string GetContentType();
        INputStream GetInputStream();
    }

    internal class ImageConverter {
    }

    internal interface IMageConverterImgElement {
        IMap<string, string> Convert(IImage image);
    }
}
