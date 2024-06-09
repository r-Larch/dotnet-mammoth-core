using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_14 : SupplierWithException<InternalResult<string>, IOException> {
        private File _file;
        private InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;

        internal InternalDocumentConverter__Anonymous_14(File file, InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter)
        {
            _file = file;
            _this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }

        public InternalResult<string> get()
        {
            return InternalDocumentConverter.withDocxFile(_file, new InternalDocumentConverter__Anonymous_13(_this_org__zwobble__mammoth__internal__InternalDocumentConverter, _file));
        }
    }
}
