using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous2 : IFunction<IArchive, InternalResult<string>> {
        private File _file;
        private InternalDocumentConverter _thisOrgZwobbleMammothInternalInternalDocumentConverter;

        internal InternalDocumentConverterAnonymous2(InternalDocumentConverter thisOrgZwobbleMammothInternalInternalDocumentConverter, File file)
        {
            _thisOrgZwobbleMammothInternalInternalDocumentConverter = thisOrgZwobbleMammothInternalInternalDocumentConverter;
            _file = file;
        }

        public InternalResult<string> Apply(IArchive zipFile)
        {
            return (_thisOrgZwobbleMammothInternalInternalDocumentConverter).ConvertToHtml(Optional.Of((_file).ToPath()), zipFile);
        }
    }
}
