using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptionsAnonymous0 : ISupplierWithException<INputStream, IoException> {
        private IMage _image;

        internal DocumentToHtmlOptionsAnonymous0(IMage image)
        {
            _image = image;
        }

        public INputStream Get()
        {
            return (_image).GetInputStream();
        }
    }
}
