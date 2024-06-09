using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous6 : IFunction<Document, InternalResult<IList<IHtmlNode>>> {
        private DocumentToHtmlOptions _conversionOptions;

        internal InternalDocumentConverterAnonymous6(DocumentToHtmlOptions conversionOptions)
        {
            _conversionOptions = conversionOptions;
        }

        public InternalResult<IList<IHtmlNode>> Apply(Document nodes)
        {
            return DocumentToHtml.ConvertToHtml(nodes, _conversionOptions);
        }
    }
}
