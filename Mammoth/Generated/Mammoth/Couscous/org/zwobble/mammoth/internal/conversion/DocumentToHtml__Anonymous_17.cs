using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.images;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_17 : Image {
        internal string _contentType;
        internal documents.Image _image;

        internal DocumentToHtml__Anonymous_17(documents.Image image, string contentType)
        {
            _image = image;
            _contentType = contentType;
        }

        public Optional<string> getAltText()
        {
            return (_image).getAltText();
        }

        public string getContentType()
        {
            return _contentType;
        }

        public InputStream getInputStream()
        {
            return (_image).open();
        }
    }
}
