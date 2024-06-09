using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_1 : SupplierWithException<InternalResult<string>, IOException> {
        internal InputStream _stream;
        internal InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;

        internal InternalDocumentConverter__Anonymous_1(InputStream stream, InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter)
        {
            _stream = stream;
            _this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }

        public InternalResult<string> get()
        {
            return InternalDocumentConverter.withDocxFile(_stream, new InternalDocumentConverter__Anonymous_0(_this_org__zwobble__mammoth__internal__InternalDocumentConverter));
        }
    }
}
