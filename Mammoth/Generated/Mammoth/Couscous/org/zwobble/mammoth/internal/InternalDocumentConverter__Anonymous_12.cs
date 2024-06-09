using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_12 : SupplierWithException<InternalResult<string>, IOException> {
        private InputStream _stream;
        private InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;

        internal InternalDocumentConverter__Anonymous_12(InputStream stream, InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter)
        {
            _stream = stream;
            _this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }

        public InternalResult<string> get()
        {
            return InternalDocumentConverter.withDocxFile(_stream, new InternalDocumentConverter__Anonymous_11(_this_org__zwobble__mammoth__internal__InternalDocumentConverter));
        }
    }
}
