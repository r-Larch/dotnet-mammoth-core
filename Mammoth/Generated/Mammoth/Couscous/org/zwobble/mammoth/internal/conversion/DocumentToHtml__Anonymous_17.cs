using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.images;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous17 : IMage {
        private string _contentType;
        private documents.Image _image;

        internal DocumentToHtmlAnonymous17(documents.Image image, string contentType)
        {
            _image = image;
            _contentType = contentType;
        }

        public IOptional<string> GetAltText()
        {
            return (_image).GetAltText();
        }

        public string GetContentType()
        {
            return _contentType;
        }

        public INputStream GetInputStream()
        {
            return (_image).Open();
        }
    }
}
