using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_5 : Function<StyleMap, DocumentToHtmlOptions> {
        private InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;

        internal InternalDocumentConverter__Anonymous_5(InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter)
        {
            _this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }

        public DocumentToHtmlOptions apply(StyleMap arg0)
        {
            return ((_this_org__zwobble__mammoth__internal__InternalDocumentConverter)._options).addEmbeddedStyleMap(arg0);
        }
    }
}
