namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_12 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
        internal DocumentToHtml__Anonymous_12(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement child) {
            return !(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor).isHeader(child);
        }
    }
}

