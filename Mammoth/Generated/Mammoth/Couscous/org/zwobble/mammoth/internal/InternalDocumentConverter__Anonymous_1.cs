using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous1 : ISupplierWithException<InternalResult<string>, IoException> {
        private INputStream _stream;
        private InternalDocumentConverter _thisOrgZwobbleMammothInternalInternalDocumentConverter;

        internal InternalDocumentConverterAnonymous1(INputStream stream, InternalDocumentConverter thisOrgZwobbleMammothInternalInternalDocumentConverter)
        {
            _stream = stream;
            _thisOrgZwobbleMammothInternalInternalDocumentConverter = thisOrgZwobbleMammothInternalInternalDocumentConverter;
        }

        public InternalResult<string> Get()
        {
            return InternalDocumentConverter.WithDocxFile(_stream, new InternalDocumentConverterAnonymous0(_thisOrgZwobbleMammothInternalInternalDocumentConverter));
        }
    }
}
