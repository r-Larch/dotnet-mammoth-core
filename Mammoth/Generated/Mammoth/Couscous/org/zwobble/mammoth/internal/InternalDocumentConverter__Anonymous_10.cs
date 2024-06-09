using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.docx;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous10 : ISupplierWithException<IOptional<string>, IoException> {
        private IArchive _zipFile;

        internal InternalDocumentConverterAnonymous10(IArchive zipFile)
        {
            _zipFile = zipFile;
        }

        public IOptional<string> Get()
        {
            return EmbeddedStyleMap.ReadStyleMap(_zipFile);
        }
    }
}
