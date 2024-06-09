using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_3 : SupplierWithException<InternalResult<string>, IOException> {
        internal File _file;
        internal InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;

        internal InternalDocumentConverter__Anonymous_3(File file, InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter)
        {
            _file = file;
            _this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }

        public InternalResult<string> get()
        {
            return InternalDocumentConverter.withDocxFile(_file, new InternalDocumentConverter__Anonymous_2(_this_org__zwobble__mammoth__internal__InternalDocumentConverter, _file));
        }
    }
}
