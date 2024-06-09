using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_6 : Function<Document, InternalResult<List<HtmlNode>>> {
        private DocumentToHtmlOptions _conversionOptions;

        internal InternalDocumentConverter__Anonymous_6(DocumentToHtmlOptions conversionOptions)
        {
            _conversionOptions = conversionOptions;
        }

        public InternalResult<List<HtmlNode>> apply(Document nodes)
        {
            return DocumentToHtml.convertToHtml(nodes, _conversionOptions);
        }
    }
}
