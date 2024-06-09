using Mammoth.Couscous.java.nio.file;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_0 : Function<Archive, InternalResult<string>> {
        private InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;

        internal InternalDocumentConverter__Anonymous_0(InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter)
        {
            _this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }

        public InternalResult<string> apply(Archive zipFile)
        {
            return (_this_org__zwobble__mammoth__internal__InternalDocumentConverter).convertToHtml(Optional.empty<Path>(), zipFile);
        }
    }
}
