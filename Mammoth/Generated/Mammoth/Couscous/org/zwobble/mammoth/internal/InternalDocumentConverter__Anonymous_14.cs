using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous14 : ISupplierWithException<InternalResult<string>, IoException> {
        private File _file;
        private InternalDocumentConverter _thisOrgZwobbleMammothInternalInternalDocumentConverter;

        internal InternalDocumentConverterAnonymous14(File file, InternalDocumentConverter thisOrgZwobbleMammothInternalInternalDocumentConverter)
        {
            _file = file;
            _thisOrgZwobbleMammothInternalInternalDocumentConverter = thisOrgZwobbleMammothInternalInternalDocumentConverter;
        }

        public InternalResult<string> Get()
        {
            return InternalDocumentConverter.WithDocxFile(_file, new InternalDocumentConverterAnonymous13(_thisOrgZwobbleMammothInternalInternalDocumentConverter, _file));
        }
    }
}
