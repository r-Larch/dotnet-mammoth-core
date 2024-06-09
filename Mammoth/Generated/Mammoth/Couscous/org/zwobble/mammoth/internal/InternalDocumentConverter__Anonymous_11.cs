using Mammoth.Couscous.java.nio.file;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous11 : IFunction<IArchive, InternalResult<string>> {
        private InternalDocumentConverter _thisOrgZwobbleMammothInternalInternalDocumentConverter;

        internal InternalDocumentConverterAnonymous11(InternalDocumentConverter thisOrgZwobbleMammothInternalInternalDocumentConverter)
        {
            _thisOrgZwobbleMammothInternalInternalDocumentConverter = thisOrgZwobbleMammothInternalInternalDocumentConverter;
        }

        public InternalResult<string> Apply(IArchive zipFile)
        {
            return (_thisOrgZwobbleMammothInternalInternalDocumentConverter).ExtractRawText(Optional.Empty<Path>(), zipFile);
        }
    }
}
