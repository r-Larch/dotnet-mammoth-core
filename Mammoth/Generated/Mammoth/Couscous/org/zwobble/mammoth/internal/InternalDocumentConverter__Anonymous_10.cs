using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.docx;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_10 : SupplierWithException<Optional<string>, IOException> {
        private Archive _zipFile;

        internal InternalDocumentConverter__Anonymous_10(Archive zipFile)
        {
            _zipFile = zipFile;
        }

        public Optional<string> get()
        {
            return EmbeddedStyleMap.readStyleMap(_zipFile);
        }
    }
}
