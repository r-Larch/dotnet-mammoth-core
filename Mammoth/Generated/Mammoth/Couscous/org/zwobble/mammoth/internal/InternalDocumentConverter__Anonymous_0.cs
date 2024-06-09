using Mammoth.Couscous.java.nio.file;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous0 : IFunction<IArchive, InternalResult<string>> {
        private InternalDocumentConverter _thisOrgZwobbleMammothInternalInternalDocumentConverter;

        internal InternalDocumentConverterAnonymous0(InternalDocumentConverter thisOrgZwobbleMammothInternalInternalDocumentConverter)
        {
            _thisOrgZwobbleMammothInternalInternalDocumentConverter = thisOrgZwobbleMammothInternalInternalDocumentConverter;
        }

        public InternalResult<string> Apply(IArchive zipFile)
        {
            return (_thisOrgZwobbleMammothInternalInternalDocumentConverter).ConvertToHtml(Optional.Empty<Path>(), zipFile);
        }
    }
}
