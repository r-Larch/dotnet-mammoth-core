using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions__Anonymous_0 : SupplierWithException<InputStream, IOException> {
        internal Image _image;

        internal DocumentToHtmlOptions__Anonymous_0(Image image)
        {
            _image = image;
        }

        public InputStream get()
        {
            return (_image).getInputStream();
        }
    }
}
