namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_6 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions _conversionOptions;
        internal InternalDocumentConverter__Anonymous_6(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions conversionOptions) {
            this._conversionOptions = conversionOptions;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml.convertToHtml(nodes, this._conversionOptions);
        }
    }
}

