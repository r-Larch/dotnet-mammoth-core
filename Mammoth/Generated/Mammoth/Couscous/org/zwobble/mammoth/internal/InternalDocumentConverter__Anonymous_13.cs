using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_13 : Function<Archive, InternalResult<string>> {
        internal File _file;
        internal InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;

        internal InternalDocumentConverter__Anonymous_13(InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter, File file)
        {
            _this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
            _file = file;
        }

        public InternalResult<string> apply(Archive zipFile)
        {
            return (_this_org__zwobble__mammoth__internal__InternalDocumentConverter).extractRawText(Optional.of((_file).toPath()), zipFile);
        }
    }
}
