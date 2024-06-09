using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Image : IDocumentElement {
        private IOptional<string> _altText;
        private IOptional<string> _contentType;
        private INputStreamSupplier _open;

        internal Image(IOptional<string> altText, IOptional<string> contentType, INputStreamSupplier open)
        {
            _altText = altText;
            _contentType = contentType;
            _open = open;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IOptional<string> GetAltText()
        {
            return _altText;
        }

        public IOptional<string> GetContentType()
        {
            return _contentType;
        }

        public INputStream Open()
        {
            return (_open).Open();
        }
    }
}
