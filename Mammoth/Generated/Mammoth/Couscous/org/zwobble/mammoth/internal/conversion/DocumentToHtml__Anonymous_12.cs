using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_12 : Predicate<DocumentElement> {
        internal DocumentToHtml__ElementConverterVisitor _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;

        internal DocumentToHtml__Anonymous_12(DocumentToHtml__ElementConverterVisitor this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
        }

        public bool test(DocumentElement child)
        {
            return !(_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor).isHeader(child);
        }
    }
}
