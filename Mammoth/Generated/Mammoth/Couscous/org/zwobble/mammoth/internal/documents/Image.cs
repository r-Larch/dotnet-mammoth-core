using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Image(IOptional<string> altText, IOptional<string> contentType, IInputStreamSupplier open) : IDocumentElement {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IOptional<string> GetAltText()
        {
            return altText;
        }

        public IOptional<string> GetContentType()
        {
            return contentType;
        }

        public INputStream Open()
        {
            return open.Open();
        }
    }
}
