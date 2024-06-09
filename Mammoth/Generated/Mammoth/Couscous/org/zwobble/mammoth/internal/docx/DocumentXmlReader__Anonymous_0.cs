namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader _this_org__zwobble__mammoth__internal__docx__DocumentXmlReader;
        internal DocumentXmlReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader this_org__zwobble__mammoth__internal__docx__DocumentXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__DocumentXmlReader = this_org__zwobble__mammoth__internal__docx__DocumentXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document(children, (this._this_org__zwobble__mammoth__internal__docx__DocumentXmlReader)._notes, (this._this_org__zwobble__mammoth__internal__docx__DocumentXmlReader)._comments);
        }
    }
}

