using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Image : DocumentElement {
        internal Optional<string> _altText;
        internal Optional<string> _contentType;
        internal InputStreamSupplier _open;

        internal Image(Optional<string> altText, Optional<string> contentType, InputStreamSupplier open)
        {
            _altText = altText;
            _contentType = contentType;
            _open = open;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public Optional<string> getAltText()
        {
            return _altText;
        }

        public Optional<string> getContentType()
        {
            return _contentType;
        }

        public InputStream open()
        {
            return (_open).open();
        }
    }
}
